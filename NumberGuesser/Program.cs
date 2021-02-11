using System;
using System.Collections.Generic;

namespace NumberGuesser
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var randomNumber = Guesser();
            Console.WriteLine("Tell me random number from 0 to 10.");
            while (true)
            {
                var yourTip = Asker();
                try
                {
                    Convert.ToInt32(yourTip);
                    if (yourTip != randomNumber.ToString())
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Wrong!");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You did it!!");
                        break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input, please enter number from 1 - 10.");
                }
            }

            Console.ReadLine();
        }

        private static int Guesser()
        {
            var random = new Random();
            var list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var index = random.Next(list.Count);
            return list[index];
        }

        private static string Asker()
        {
            var ans = Console.ReadLine();
            return ans;
        }
    }
}
