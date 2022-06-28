using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallRPG
{
    internal class Cursor
    {
        public delegate void DrawHandler(SquareMap map, Unit unit, char sprite);
        public static event DrawHandler DrawEvent;

        void PrintSummon(Unit unit, Graphic.SpritesEnum sprite)
        {
            int tempX = Console.CursorLeft;
            int tempY = Console.CursorTop;
            int currentX = unit.PosX;
            int currentY = unit.PosY;

            Console.SetCursorPosition(currentX, currentY);

            Console.Write(sprite);

            Console.SetCursorPosition(tempX, tempY);
        }

        public static void DrawCall(SquareMap map, Unit unit, char sprite)
        {
            Console.SetCursorPosition(unit.PosX, unit.PosY);

            Console.Write(sprite);
            Console.SetCursorPosition(0, 0);

            map.PrintAt(unit.PosX, unit.PosY);
        }

    }
}
