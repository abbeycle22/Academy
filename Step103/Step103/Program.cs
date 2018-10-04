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

            //(Number 2)

            //int[] childrensAges = { 1, 3, 3, 9, 14, 16, 18 };

            //for (; ; )
            //{
            //    Console.WriteLine("Too Many");

            //}

            //(Number 3)
            //int[] childrensAges = { 1, 3, 3, 9, 14, 16, 18 };

            //for (int i = 0; i < childrensAges.Length; i++)
            //    Console.WriteLine("The Children are " + childrensAges[i]);

            //(Number 4)

            //int[] childrensAges = { 1, 3, 3, 9, 14, 16, 18 };

            //for (int i = 0; i < childrensAges.Length; i++)
            //{
            //    if (i < 10)
            //    {
            //        Console.WriteLine("The Children are " + childrensAges[i]);
            //    }
            //    else
            //    break;
            //}

            //(Number 5)
            int[] grade = { 78, 88, 99, 45, 69 };

            for (int i = 0; i < grade.Length; i++) 
            {
                if (i <= 80)
                {
                    Console.WriteLine("Passing grades are " + grade[i]);
                }

            }

            Console.ReadLine();
        }
    }
}
