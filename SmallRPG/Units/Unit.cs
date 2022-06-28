using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallRPG
{
    internal abstract class Unit : IHaveHealth, IHaveInventory
    {
        protected Unit(string name, int hP, int exp)
        {
            Name=name;
            HP=hP;
            Level = ParseLevel();
        }

        protected static readonly int _dropExp = 0;
        protected static readonly Weapon _defaulthWpn = new DefaulthWeapon(7, "No weapon");

        public string Name { get; protected set; }
        public int HP { get; set; }
        public int Level { get; protected set; }
        public int Experience { get; set; }
        public int PosX { get; set; } = 5;
        public int PosY { get; set; } = 5;

        public virtual bool Dead()
        {
            if (HP <= 0)
            {
                Console.WriteLine($"{Name} is dead");
                return true;
            }
            else
            {
                return false;
            }
        }

        public virtual int GetDamage(int damage)
        {
            return HP -= damage;
        }

        public virtual void OpenInventory()
        {
            throw new NotImplementedException();
        }

        protected void HasntInventoryMsg()
        {
            Console.WriteLine($"{Name} hasn't inventory!");
            Console.ReadKey();
        }

        private int ParseLevel()
        {
            if (Experience > Configs.MAX_EXP) 
            {
                Experience = Configs.MAX_EXP;
                return Configs.MAX_LEVEL;
            }

            for (int i = 0; i < Configs.LEVELS_EXP.Length; i++)
            {
                if (Configs.LEVELS_EXP[i] >= Experience)
                {
                    return i + 1;
                }
            }

            return 0;
        }
        public override string ToString()
        {
            return $"It's {Name}\t\tHp - {HP}\nLevel - {Level}\t\tWeapon - haven't weapon";
        }
    }
}
