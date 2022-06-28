using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallRPG
{
    internal class DefaulthWeapon : Weapon
    {
        public DefaulthWeapon(int damage, string name) : base(damage, name)
        {
        }

        public override int Hit()
        {
            return Damage;
        }
    }
}
