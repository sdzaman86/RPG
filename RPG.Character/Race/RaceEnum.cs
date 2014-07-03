using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace RPG.Character
{
    [DataContract]
    public enum RaceEnum
    {
        [EnumMember(Value = "Human")]
        Human,

        [EnumMember(Value = "Dwarf")]
        Dwarf,

        [EnumMember(Value = "Elf")]
        Elf,

        [EnumMember(Value = "Gnome")]
        Gnome,

        [EnumMember(Value = "HalfElf")]
        HalfElf,

        [EnumMember(Value = "HalfOrc")]
        HalfOrc,

        [EnumMember(Value = "Halfling")]
        Halfling,
    }
}
