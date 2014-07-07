using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Skills
{
    public abstract class AbstractCheck
    {
        public abstract int DC;

        public abstract string Failure;

        public abstract string Success;

        public abstract int Bonus;
    }
}
