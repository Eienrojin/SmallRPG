using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallRPG.Units
{
    internal class Player : Unit, IHaveInventory, IMoveable
    {
        public Player(string name, int hP, int exp) : base(name, hP, exp)
        {
        }

        public Consumables[]? Consumables { get; set; } = new Consumables[5];
        public Weapon[]? Weapons { get; set; } = new Weapon[2];
        public Weapon WeaponSlot { get; set; } = _defaulthWpn;
        public char _sprite = Graphic.Sprites[Graphic.SpritesEnum.PLAYER];

        //public void LookAt()

        public override bool Dead()
        {
            if (HP <= 0)
            {
                //GAMEOVER
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Move(SquareMap map)
        {
            ConsoleKey key;
            key = Console.ReadKey(true).Key;

            switch (key)
            {
                case ConsoleKey.LeftArrow:
                    if (map.IsPointABorder(PosX, PosY))
                        PosX--;
                    break;
                case ConsoleKey.UpArrow:
                    if (map.IsPointABorder(PosX, PosY - 1))
                        PosY--;
                    break;
                case ConsoleKey.RightArrow:
                    if (map.IsPointABorder(PosX + 1, PosY))
                        PosX++;
                    break;
                case ConsoleKey.DownArrow:
                    if (map.IsPointABorder(PosX, PosY + 1))
                        PosY++;
                    break;
                case ConsoleKey.X:
                    break;
                case ConsoleKey.Z:
                    break;
            }
        }

        override public void OpenInventory()
        {
            ConsoleKey answer;

            while (true)
            {
                UIUtills.PrintConsumables(Consumables);

                Console.WriteLine("1. Viev weapons" +
                    "\n2. Use item" +
                    "\n3. Delete item" +
                    "\n4. Check description" +
                    "\n5. Close");

                answer = Console.ReadKey().Key;

                switch (answer)
                {
                    case ConsoleKey.D1:
                        break;
                    case ConsoleKey.D2:
                        break;
                    case ConsoleKey.D3:
                        break;
                    case ConsoleKey.D4:
                        break;
                }

                if (answer != ConsoleKey.Backspace) break;
            }
        }

        public override string ToString()
        {
            return $"You're - {Name}" + $"\t\tWeapon: " + 
                $"\nLevel - {Level}\t\t\t" + WeaponSlot.Name +
                $"\nHP - {HP}\t\t\t" + "Damage - " + WeaponSlot.Damage;
        }
    }
}
