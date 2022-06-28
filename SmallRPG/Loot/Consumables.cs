using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallRPG
{
    internal class Consumables
    {
        public int Heal { get; set; }
        public string Name { get; set; }

        public virtual int Buff()
        {
            return Heal;
        }

        public override string ToString()
        {
            return $"Name - {Name}" +
                $"\nHeals - {Heal}";
        }
    }
}
