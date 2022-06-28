using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallRPG.Units
{
    internal abstract class HumanLike : Unit
    {
        public HumanLike(string name, int hP, int exp) : base(name, hP, exp)
        {
        }

        static protected readonly int _capacityConsum = 3;
        static protected readonly int _capacityWpn = 2;
        static protected readonly Weapon _stdWeapon = new DefaulthWeapon(5, "");

        public Consumables[]? Consumables { get; set; } = new Consumables[_capacityConsum];
        public Weapon[]? Weapons { get; set; } = new Weapon[_capacityWpn];

        public Weapon WeaponSlot { get; set; } = _stdWeapon;

        //public void LookAt()

        public override bool Dead()
        {
            if (HP <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Move()
        {
            throw new NotImplementedException();
        }

        override public void OpenInventory()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"It's - {Name}" + $"\t\tWeapon: " +
                $"\nLevel - {Level}\t\t\t" + WeaponSlot.Name +
                $"\nHP - {HP}\t\t\t" + "Damage - " + WeaponSlot.Damage;
        }
    }
}
