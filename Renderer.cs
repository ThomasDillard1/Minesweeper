public static class Renderer
{
    public static void ShowStartScreen()
    {
        Console.WriteLine("Welcome to Minesweeper!");
        Console.WriteLine("Press ENTER to start...");

        while (true)
        {
            var key = Console.ReadKey(intercept: true); // true = don’t display key
            if (key.Key == ConsoleKey.Enter)
                break;
        }

        Console.WriteLine("\nStarting game!");
    }
}