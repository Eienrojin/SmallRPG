namespace SmallRPG
{
    internal class SquareMap
    {
        public SquareMap(int size, char border, char floor, bool generateWater)
        {
            Map = new char[size, size];

            Border = border;
            Floor = floor;

            FullGenerator(size, generateWater);
        }

        public SquareMap(int size, bool generateWater)
        {
            Map = new char[size, size];

            FullGenerator(size, generateWater);
        }

        private char[,] Map { get; set; }
        public char[] Borders = Graphic.Borders.Values.ToArray();
        public char Border { get; set; } = '▓';
        public char Floor { get; set; } = '▒';

        private void GenerateBorders(int size)
        {
            for (int i = 0; i < size; i++)
            {
                Map[i, 0] = Border;
                Map[i, size - 1] = Border;

                Map[0, i] = Border;
                Map[size - 1, i] = Border;
            }
        }

        private void GenerateFloor()
        {
            for (int i = 0; i < Map.GetLength(0); i++)
                for (int j = 0; j < Map.GetLength(1); j++)
                    Map[i, j] = Floor;
        }

        private void GenerateDoors()
        {
            int[] leftBorderCenter = GetBorderCenter(Direction.LEFT);
            int[] rightBorderCenter = GetBorderCenter(Direction.RIGHT);
            int[] upBorderCenter = GetBorderCenter(Direction.UP);
            int[] downBorderCenter = GetBorderCenter(Direction.DOWN);

            Map[rightBorderCenter[0], rightBorderCenter[1]] = Graphic.Images[Graphic.ImagesEnum.DOOR_HORIZONTAL];
            Map[leftBorderCenter[0], leftBorderCenter[1]] = Graphic.Images[Graphic.ImagesEnum.DOOR_HORIZONTAL];

            Map[upBorderCenter[0], upBorderCenter[1]] = Graphic.Images[Graphic.ImagesEnum.DOOR_VERTICAL];
            Map[downBorderCenter[0], downBorderCenter[1]] = Graphic.Images[Graphic.ImagesEnum.DOOR_VERTICAL];
        }

        private void AutoGenerateWater()
        {
            int left = GetBorderCenter(Direction.LEFT)[1];

            Map[2, 2] = Graphic.Images[Graphic.ImagesEnum.BORDER_WATER];

            for (int i = 2; i < Map.GetLength(1) - 2; i++)
            {
                if (i != left)
                { 
                    Map[2, i] = Graphic.Images[Graphic.ImagesEnum.BORDER_WATER];
                    Map[Map.GetLength(1) - 3, i] = Graphic.Images[Graphic.ImagesEnum.BORDER_WATER];
                }
            }

            for (int i = 2; i < Map.GetLength(1) - 2; i++)
            {
                if (i != left)
                {
                    Map[i, 2] = Graphic.Images[Graphic.ImagesEnum.BORDER_WATER];
                    Map[i, Map.GetLength(1) - 3] = Graphic.Images[Graphic.ImagesEnum.BORDER_WATER];
                }
            }
        }

        public int[] FindCenter()
        {
            int[] Center = new int[1];

            Center[0] = Map.GetLength(0) / 2;
            Center[1] = Map.GetLength(1) / 2;

            return Center;
        }

        public int[] GetBorderCenter(Direction direction)
        {
            int lenghtFirstDim = Map.GetLength(0) - 1;
            int lenghtSecondDim = Map.GetLength(1) - 1;

            int[] someCenter = new int[2];

            switch (direction)
            {
                case Direction.LEFT:
                    someCenter[0] = 0;
                    someCenter[1] = lenghtSecondDim / 2;
                    break;
                case Direction.RIGHT:
                    someCenter[0] = lenghtFirstDim;
                    someCenter[1] = lenghtSecondDim / 2;
                    break;
                case Direction.UP:
                    someCenter[0] = lenghtFirstDim / 2;
                    someCenter[1] = 0;
                    break;
                case Direction.DOWN:
                    someCenter[0] = lenghtFirstDim / 2;
                    someCenter[1] = lenghtSecondDim;
                    break;
            }

            return someCenter;
        }

        private void FullGenerator(int size, bool waterGenerator)
        {
            GenerateFloor();
            GenerateBorders(size);
            GenerateDoors();

            if (waterGenerator)
                AutoGenerateWater();
        }

        public void Print()
        {
            for (int i = 0; i < Map.GetLength(0); i++)
            {
                Console.WriteLine();

                for (int j = 0; j < Map.GetLength(1); j++)
                    Console.Write(Map[i, j]);
            }
        }

        public void PrintAt(int x, int y)
        {
            int tempPosX = Console.CursorLeft;
            int tempPosY = Console.CursorTop;
            char texture = Map[x, y];

            Console.SetCursorPosition(y, x + 1);
            Console.Write(texture);
            Console.SetCursorPosition(tempPosY, tempPosX);
        }

        public void PrintAtAndReplace(int x, int y, char texture)
        {
            if (Map.GetLength(0) > y || Map.GetLength(1) > x)
            {
                Map[x, y] = texture;
            }
            else
            {
                #if DEBUG
                Console.WriteLine("Слишком большой размер");
                #endif
            }
        }

        public char GetImageAt(int x, int y)
        {
            return Map[x, y];
        }

        public bool IsPointABorder(int x, int y)
        {
            for (int i = 0; i < Borders.Length - 1; i++)
                if (Borders[i] == GetImageAt(x, y))
                    return true;

            return false;
        }

        public enum Direction
        {
            UP,
            DOWN,
            LEFT,
            RIGHT
        }
    }
}
