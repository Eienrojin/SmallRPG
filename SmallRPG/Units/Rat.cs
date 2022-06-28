using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallRPG.Units
{
    internal sealed class Rat : Unit
    {
        public Rat(string name, int hP, int exp) : base(name, hP, exp)
        {
            Experience = 500;
        }

        public int Bite()
        {
            Random random = new Random();

            return random.Next(1, 6);
        }

        public override void OpenInventory()
        {
            HasntInventoryMsg();
        }
    }
}
