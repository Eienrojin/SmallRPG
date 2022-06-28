using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallRPG
{
    internal class Sword : Weapon, ICanLife
    {
        public Sword(int maxhp, int hp, int damage, string name) : base(damage, name)
        {
            HP = hp;
            MaxHP = maxhp;
        }

        public int HP { get; set; }
        public int MaxHP { get; set; }

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

        override public int Hit()
        {
            Random random = new();

            double chance = random.NextDouble();
            HP -= random.Next(1, 5);

            if (chance <= 0.7)
                return Damage * 2;
            else
                return Damage;
        }

        public override string ToString()
        {
            return $"Name - {Name}" +
                $"\nHp - {HP}" +
                $"\nDamage - {Damage}";
        }
    }
}
