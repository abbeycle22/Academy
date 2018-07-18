using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @while
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a number.");
            int number = Convert.ToInt32(Console.ReadLine());
            bool guessedNum = number == 17;

            while (!guessedNum)
            {
                switch (number)
                {
                    case 15:
                        Console.WriteLine("You guessed 15. Try again.");
                        Console.WriteLine("Guess a number.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 45:
                        Console.WriteLine("You guessed 45. Try again.");
                        Console.WriteLine("Guess a number.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 89:
                        Console.WriteLine("You guessed 89. Try again.");
                        Console.WriteLine("Guess a number.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 17:
                        Console.WriteLine("You guessed 17. That is correct.");
                        guessedNum = true;
                        break;
                    default:
                        Console.WriteLine("Try again.");
                        Console.WriteLine("Guess a number.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }


            //do
            //{
            //    switch (number)
            //    {
            //        case 15:
            //            Console.WriteLine("You guessed 15. Try again.");
            //            Console.WriteLine("Guess a number.");
            //            number = Convert.ToInt32(Console.ReadLine());
            //            break;
            //        case 45:
            //            Console.WriteLine("You guessed 45. Try again.");
            //            Console.WriteLine("Guess a number.");
            //            number = Convert.ToInt32(Console.ReadLine());
            //            break;
            //        case 89:
            //            Console.WriteLine("You guessed 89. Try again.");
            //            Console.WriteLine("Guess a number.");
            //            number = Convert.ToInt32(Console.ReadLine());
            //            break;
            //        case 17:
            //            Console.WriteLine("You guessed 17. That is correct.");
            //            guessedNum = true;
            //            break;
            //        default:
            //            Console.WriteLine("Try again.");
            //            Console.WriteLine("Guess a number.");
            //            number = Convert.ToInt32(Console.ReadLine());
            //            break;
            //    }
            //}
            //while (!guessedNum);

            Console.Read();
        }
    }
}
