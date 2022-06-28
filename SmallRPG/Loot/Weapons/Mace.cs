using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallRPG
{
    internal class Mace : Weapon, ICanLife
    {
        public Mace(int hP, int maxHP, int damage, string name) : base(damage, name)
        {
            HP=hP;
            MaxHP=maxHP;
        }

        public int HP { get; set; }
        public int MaxHP { get; }

        override public int Hit()
        {
            Random random = new Random();

            if (random.NextDouble() <= 0.5)
            {
                double extraDamage = Damage * 1.5;

                return (int)extraDamage;
            }
            else
            {
                return Damage;
            }
        }

        public bool Dead()
        {
            if (HP <= 0)
            {
                Console.WriteLine($"{Name} is broken");
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return $"Name - {Name}" +
                $"\nHp - {HP}" +
                $"\nDamage - {Damage}";
        }
    }
}
