using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_01.Field
{
    class BattleField : ICloneable
    {
        private List<object> parts = new List<object>();

        public void Add(string part)
        {
            this.parts.Add(part);
        }

        public override string ToString()
        {
            string str = String.Empty;
            for (var i = 0; i < parts.Count(); i++)
            {
                str += this.parts[i] + ", ";
            }
            str = str.Remove(str.Count() - 2);
            return str;
        }

        public object Clone()
        {
            BattleField clone = (BattleField)this.MemberwiseClone();
            clone.parts = this.parts;
            return clone;
        }
    }
}
