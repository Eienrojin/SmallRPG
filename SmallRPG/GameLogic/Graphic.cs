namespace SmallRPG
{
    public static class Graphic
    {
        static Graphic()
        {
            InitAllImages();
            InitAllSprites();
            InitAllBorders();
        }

        public static readonly Dictionary<SpritesEnum, char>? Sprites = new Dictionary<SpritesEnum, char>();
        public static readonly Dictionary<ImagesEnum, char>? Images = new Dictionary<ImagesEnum, char>();
        public static readonly Dictionary<ImagesEnum, char>? Borders = new Dictionary<ImagesEnum, char>();

        private static void InitAllImages()
        {
            Images.Add(ImagesEnum.BORDER, '▓');
            Images.Add(ImagesEnum.DOOR_HORIZONTAL, '─');
            Images.Add(ImagesEnum.DOOR_VERTICAL, '├');
            Images.Add(ImagesEnum.BORDER_WATER, '░');
        }

        private static void InitAllSprites()
        {
            Sprites.Add(SpritesEnum.PLAYER, '@');
            Sprites.Add(SpritesEnum.ENEMY, 'X');

        }

        private static void InitAllBorders()
        {
            Borders.Add(ImagesEnum.BORDER, '▓');
            Borders.Add(ImagesEnum.BORDER_WATER, '░');
        }

        public enum ImagesEnum 
        {
            BORDER,
            DOOR_HORIZONTAL,
            DOOR_VERTICAL,
            BORDER_WATER
        }

        public enum BordersEnum
        {
            BORDER,
            BORDER_WATER
        }

        public enum SpritesEnum
        {
            PLAYER,
            ENEMY
        }
    }
}
