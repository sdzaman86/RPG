using System;
using System.Collections.Generic;
using System.Reflection;

namespace RPG.General
{
    /// <summary>
    /// The AbstractReflectionFactory provides a dynamic abstract factory implementation. Assuming your objects extend a common interface (TIObject), the factory will utilize reflection
    /// to find all applicable objects that can be created.
    /// </summary>
    /// <typeparam name="TIObject">Interface class the objects implement</typeparam>
    /// <typeparam name="TDefaultObject">Default Object to be created if a specific object is not found; expected to implement TIObject</typeparam>
    /// <example>
    /// class MammalFactory : AbstractReflectionFactory<IMammal, UnkownMammal>{}
    ///
    /// IMammal Person = new MammalFactory().CreateInstance("Person");
    /// </example>
    /// <remarks>
    /// Note that currently you will have to subclass AbstractReflectionFactory in your desired assembly. There is no code needed inside the class besides defining the required
    /// inheritance parameters.
    ///
    /// TODO: Investigate a way for the AbstractReflectionFactory to be standalone without needing to subclass in the desired assembly.
    /// </remarks>
    public abstract class AbstractReflectionFactory<TIObject, TDefaultObject>
    {
        Dictionary<string, Type> objects;
        //protected abstract Type DefaultObjectType();
        public AbstractReflectionFactory()
        {
            LoadTypesICanReturn();
        }
        /// <summary>
        /// Returns an instance of the desired object.
        /// </summary>
        /// <param name="description">Description (i.e. class name) of the object you want to create</param>
        /// <returns>Object implementing the interface TIObject</returns>
        public TIObject CreateInstance(string description)
        {
            Type t = GetTypeToCreate(description);
            if (t == null)
                return (TIObject)Activator.CreateInstance(typeof(TDefaultObject));
            return (TIObject)Activator.CreateInstance(t);
        }
        /// <summary>
        /// Returns the Type of the object to be created based on the objectName provided
        /// </summary>
        /// <param name="objectName">String name of the object to create</param>
        /// <returns>Type</returns>
        private Type GetTypeToCreate(string objectName)
        {
            foreach (var obj in this.objects)
            {
                if (obj.Key.Contains(objectName))
                {
                    return this.objects[obj.Key];
                }
            }
            return null;
        }
        /// <summary>
        /// Utilizes reflection to find all objects in the assembly implementing the interface TIObject
        /// </summary>
        private void LoadTypesICanReturn()
        {
            this.objects = new Dictionary<string, Type>();
            Type[] typesInThisAssembly = Assembly.GetAssembly(this.GetType()).GetTypes();
            foreach (Type type in typesInThisAssembly)
            {
                if (type.GetInterface(typeof(TIObject).ToString()) != null)
                {
                    this.objects.Add(type.Name, type);
                }
            }
        }
    }
}
