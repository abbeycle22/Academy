using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step103
{
    class Program
    {
        static void Main(string[] args)
        {
            ////(Number 1)
            //string[] names = { "Lorri", "Lane", "Abbey", "Kyle", "Casi", "Kendall", "Kaidyn" };

            //Console.WriteLine("Last name of the family that lives in the Pacific Northwest?");
            //string text = Console.ReadLine();

            //Console.WriteLine("Here are the members of the " + text + " family:");
            //for (int i = 0; i < names.Length; i++)
            //{
            //    Console.WriteLine(names[i] + " " + text);
            //}

            ////(Number 2)

            //int[] childrensAges = { 1, 3, 3, 9, 14, 16, 18 };

            //for (; ; )
            //{
            //    Console.WriteLine("Too Many");

            //}

            ////(Number 3)
            //int[] childrensAges = { 1, 3, 3, 9, 14, 16, 18 };

            //for (int i = 0; i < childrensAges.Length; i++)
            //    Console.WriteLine("The Children are " + childrensAges[i]);

            ////(Number 4)
            //for (int i = 80; i <= 100; i++)
            //{
            //    Console.WriteLine("Value of i: {0}", i);
            //}


            ////(Number 5)

            //for (int i = 80; i < 100; i++)
            //{
            //    Console.WriteLine("Value of i: {0}", i);
            //}

            ////(Number 6 & 7 & 8) --- i cannot figure out how to get this to not write "they are not on the list" for the other people

            //List<string> names = new List<string>() { "Lorri", "Abbey", "Lane", "Rosemary", "Paul", "Kyle", "Casi" };
            //Console.WriteLine("Please type a name ");
            //string userName = Console.ReadLine();

            //for (int i = 0; i < names.Count; i++)
            //{
            //    if (names[i] == userName)
            //    {
            //        Console.WriteLine("They are on the list");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("They are not on the list");
            //        break;
            //    }
            //}

            //(Number 9)

            List<string> names = new List<string>() { "Lorri", "Lane", "Paul", "Abbey", "Lane", "Rosemary", "Paul", "Kyle", "Casi" };
            Console.WriteLine("Please type a name ");
            string userName = Console.ReadLine();

            string listA = names.FindAll( names = userName  );


            Console.ReadLine();
        }
    }
}

