using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallRPG
{
    abstract internal class Weapon : IWeapon
    {
        protected Weapon(int damage, string name)
        {
            Damage=damage;
            Name=name;
        }

        public int Damage { get; set; }
        public string Name { get; set; }

        public virtual int Hit()
        {
            return Damage;
        }

        public override string ToString()
        {
            return $"Name - {Name}" +
                $"\nDamage - {Damage}";
        }
    }
}
