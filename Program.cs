for (int x = 1; x != 101; x++)
    if (x % 3 == 0 && x % 5 == 0)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"{x} BOTH");
            Console.ForegroundColor = ConsoleColor.White;
        }
    else if (x % 3 == 0)
        {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"{x} Fire");
        Console.ForegroundColor = ConsoleColor.White;
        }
        else if (x % 5 == 0)
        {
        Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{x} Electric");
        Console.ForegroundColor = ConsoleColor.White;
        }
   else
    {
        Console.WriteLine($"{x} Normal");
    }
