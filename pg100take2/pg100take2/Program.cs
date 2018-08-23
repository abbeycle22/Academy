using System;
using System.Collections.Generic;

namespace pg100take2
{
    class Program
    {
        static void Main()
        {

            //#1
            //String[] oneDimArray = new String[6];
            //oneDimArray[0] = "Hello";
            //oneDimArray[1] = "You";
            //oneDimArray[2] = "are";
            //oneDimArray[3] = "amazing";
            //oneDimArray[4] = "thank";
            //oneDimArray[5] = "life";

            //Console.WriteLine("Please select a number between 0 and 5.");
            //int i = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(oneDimArray[i]);
            //Console.ReadLine();

            //#2 & 3
            //int[] oneDimArray = new int[6];
            //oneDimArray[0] = 3;
            //oneDimArray[1] = 9;
            //oneDimArray[2] = 81;
            //oneDimArray[3] = 162;
            //oneDimArray[4] = 324;
            //oneDimArray[5] = 648;

            //Console.WriteLine("Please select a number between 0 and 5.");
            //int i = Convert.ToInt32(Console.ReadLine());

            //if (i>5)
            //{
            //    Console.WriteLine("Please select a different number.");
            //}
            //else
            //{
            //    Console.WriteLine(oneDimArray[i]);
            //}

            //#4
            List<string> firstList = new List<string>();
            firstList.Add("Monday");
            firstList.Add("Tuesday");
            firstList.Add("Wednesday");
            firstList.Add("Thursday");
            firstList.Add("Friday");
            firstList.Add("Saturday");

            Console.WriteLine("Please select a number between 0 and 5.");
            int i = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(firstList[i]);
            Console.ReadLine();

        }
    }
}
