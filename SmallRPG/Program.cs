namespace SmallRPG.Units;

class Program
{
    private static void Main()
    {
        Player player = new("Test Player", 100, 0);
        Rat rat = new("ratmorgen", 30, 5);

        SquareMap map = new SquareMap(11, true);

        map.Print();

        while (true)
        {
            Cursor.DrawCall(map, player, player._sprite);
        }

/*        Fight(player, rat);*/
    }

    static void Fight(Player player, Unit enemy)
    {
        bool playerRanAway = false;
        ConsoleKey key;
        Random random = new Random();

        while (true)
        {
            Console.Clear();

            Console.WriteLine(player.ToString());
            Console.WriteLine("\n" + enemy.ToString() + "\n");

            Console.WriteLine("1. Hit" +
                "\n2. View inventory" +
                "\n3. Try to look in enemy inventory" +
                "\n4. Try to run away");

            key = Console.ReadKey().Key;

            switch (key)
            {
                case ConsoleKey.D1:
                    enemy.GetDamage(player.WeaponSlot.Hit());
                    break;

                case ConsoleKey.D2:
                    player.OpenInventory();
                    break;

                case ConsoleKey.D3:
                    if (random.NextDouble() <= 0.3)
                        TryToLookInUnitInventory(enemy);
                    else
                        Console.WriteLine("Fail!");
                    break;

                case ConsoleKey.D4:
                    //Переписать
                    if (player.Level - enemy.Level < 2)
                        playerRanAway = true;

                    break;
                case ConsoleKey.D5:
                    break;
                case ConsoleKey.D6:
                    break;
                case ConsoleKey.D7:
                    break;
                case ConsoleKey.D8:
                    break;
                case ConsoleKey.D9:
                default:
                    break;
            }

            if (playerRanAway || player.Dead() || enemy.Dead())
                break;
        }
    }

    static void TryToLookInUnitInventory (Unit unit)
    {
        if (unit is Rat)
            ((Rat)unit).OpenInventory();
    }
}