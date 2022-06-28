using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallRPG.Units
{
    internal abstract class AnimalLike : Unit
    {
        public AnimalLike(string name, int hP, int experience) : base(name, hP, experience)
        {
            Experience = 50;
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
