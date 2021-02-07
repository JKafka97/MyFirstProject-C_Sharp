using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            var RandomNumber =  Guesser();
            Console.WriteLine("Tell me random number from 0 to 10.");
            while(true)
            {
                var YourTip = Asker(); 
                if (YourTip != RandomNumber.ToString())
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong!");
                    Console.ResetColor();
                } else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You did it!!");
                    break;
                }
            }
            
            Console.ReadLine();
        }
    
        static int Guesser()
        {
            var random = new Random();
            var list = new List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            int index = random.Next(list.Count);
            return list[index];
        }

        static string Asker() 
        {
            var Ans = Console.ReadLine();
            return Ans;

        }
    
    }


}
