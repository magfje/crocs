namespace crocs {
    internal class Program {
        static void Main(string[] args) {

            int points = 0;
            while (true) {
                int no1 = new Random().Next(0, 9);
                int no2 = new Random().Next(0, 9);
                if (points > -1) {
                    Console.ForegroundColor = ConsoleColor.Green;
                } else {
                    Console.ForegroundColor = ConsoleColor.Red;
                }

                Console.WriteLine($"Points: {points}");
                Console.ResetColor();

                Console.WriteLine("Smaller, Bigger or Equal? ");
                Console.WriteLine($"{no1} _ {no2}");
                string? input = Console.ReadLine();

                if (input == "<" || input == ">" || input == "=") {
                    Console.Clear();
                    if (no1 > no2 && input == ">"
                    || no1 < no2 && input == "<"
                    || no1 == no2 && input == "=") {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"{no1} {input} {no2} is correct \r\n");
                        points++;
                    } else {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"{no1} {input} {no2} is wrong \r\n");
                        points--;
                    }
                    Console.ResetColor();
                } else {
                    Console.Clear();
                    Console.WriteLine($"'{input}' is not a valid input. Type <, > or =.\r\n");

                }

            }
        }
    }
}