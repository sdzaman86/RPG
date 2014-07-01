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
        Human
    }
}
