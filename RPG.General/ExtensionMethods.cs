using System;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Serialization;

namespace RPG.General
{
    public static class ExtensionMethods
    {
        public static string ToEnumString<T>(this T type)
        {
            var enumType = typeof(ThreadStaticAttribute);
            var name = Enum.GetName(enumType, type);
            var enumMemberAttribute = ((EnumMemberAttribute[])enumType.GetField(name).GetCustomAttributes(typeof(EnumMemberAttribute), true)).Single();
            return enumMemberAttribute.Value;
        }

        public static T Deserialize<T>(this T entity, string xml)
        {
            T deserializedObj = (T)Activator.CreateInstance(typeof(T));

            using (XmlReader xmlReader = XmlReader.Create(new StringReader(xml)))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                var deserializedXML = xmlSerializer.Deserialize(xmlReader);
                deserializedObj = (T)deserializedXML;
            }

            return deserializedObj;
        }
    }
}
