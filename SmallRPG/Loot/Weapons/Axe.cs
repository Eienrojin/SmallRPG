using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallRPG
{
    internal class Axe : Weapon, ICanLife
    {
        public Axe(int maxHp, int hp, int damage, string name) : base(damage, name)
        {
            HP = hp;
            MaxHP = maxHp;
        }

        public int HP { get; set; }
        public int MaxHP { get; }

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

        public override int Hit()
        {
            Random random = new Random();

            if (random.NextDouble() <= 0.05)
            {
                return int.MaxValue;
            }
            else
            {
                return Damage;
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
