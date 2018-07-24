using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayandList
{
    class Program
    {
        static void Main()
        {
            List<string> stringList = new List<string>();
            stringList.Add("Lane");
            stringList.Add("Steven");
            stringList.Add("Mike");
            stringList.Add("Cole");
            stringList.Add("Lorri");
            stringList.Add("Erin");

            Console.WriteLine("Choose an index number");
            int stringChoice = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(stringList[stringChoice]);
            Console.ReadLine();

            
            //int[] intArray = { 2, 4, 6, 8, 10, 15, 26 };
            //Console.WriteLine("Select a number");
            //int array = Convert.ToInt32(Console.ReadLine());
            //bool array1 = array <= 6; 

            //while (!array1) 
            //    switch (array)
            //    {
            //        default:
            //            Console.WriteLine("Try again.");
            //            Console.WriteLine("Select a number");
            //            array = Convert.ToInt32(Console.ReadLine());
            //            break;
            //        case 0:
            //            Console.WriteLine(intArray[array]);
            //            array1 = true;
            //            break;
            //        case 1:
            //            Console.WriteLine(intArray[array]);
            //            array1 = true;
            //            break;
            //        case 2:
            //            Console.WriteLine(intArray[array]);
            //            array1 = true;
            //            break;
            //        case 3:
            //            Console.WriteLine(intArray[array]);
            //            array1 = true;
            //            break;
            //        case 4:
            //            Console.WriteLine(intArray[array]);
            //            array1 = true;
            //            break;
            //        case 5:
            //            Console.WriteLine(intArray[array]);
            //            array1 = true;
            //            break;
            //        case 6:
            //            Console.WriteLine(intArray[array]);
            //            array1 = true;
            //            break;
            //    }

            //Console.ReadLine();




            //string[] stringArray1 = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"};
            //Console.WriteLine("Select a number between 0 and 11:");
            //int array1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(stringArray1[array1]);
            //Console.ReadLine(); 
        }
    }
}
