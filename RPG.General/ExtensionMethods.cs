using System;
using System.Linq;
using System.Runtime.Serialization;

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
    }
}
