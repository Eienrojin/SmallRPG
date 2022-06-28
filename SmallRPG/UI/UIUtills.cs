using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallRPG
{
    internal class UIUtills
    {
        static public void PrintConsumables(Consumables[] Consum)
        {
            for (int i = 0; i < Consum.Length - 1; i++)
            {
                if (Consum[i] == null)
                {
                    Console.WriteLine($"{i}. Empty");
                }
                else
                {
                    Console.WriteLine($"{i}. {Consum[i].Name}");
                }
            }
        }

        static public void PrintWeapons(Weapon[] Weapons)
        {
            for (int i = 0; i < Weapons.Length - 1; i++)
            {
                if (Weapons[i] == null)
                {
                    Console.WriteLine($"{i}. Empty");
                }
                else
                {
                    Console.WriteLine($"{i}. {Weapons[i].Name}");
                }
            }
        }

        static public void PrintAll(Consumables[] Consum, Weapon[] Weapons)
        {
            PrintConsumables(Consum);
            PrintWeapons(Weapons);
        }
    }
}
