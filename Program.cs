var points = 0;
while (true)
{
    var no1 = new Random().Next(0, 9);
    var no2 = new Random().Next(0, 9);
    Console.ForegroundColor = points > -1 ? ConsoleColor.Green : ConsoleColor.Red;

    Console.WriteLine($"Points: {points}");
    Console.ResetColor();

    Console.WriteLine("Smaller, Bigger or Equal? ");
    Console.WriteLine($"{no1} _ {no2}");
    var input = Console.ReadLine();

    if (input is "<" or ">" or "=")
    {
        Console.Clear();
        if ((no1 > no2 && input == ">")
            || (no1 < no2 && input == "<")
            || (no1 == no2 && input == "="))
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{no1} {input} {no2} is correct \r\n");
            points++;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{no1} {input} {no2} is wrong \r\n");
            points--;
        }

        Console.ResetColor();
    }
    else
    {
        Console.Clear();
        Console.WriteLine($"'{input}' is not a valid input. Type <, > or =\r\n");
    }
}