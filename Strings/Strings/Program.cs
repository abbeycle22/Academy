using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Concatenate three strings.
            //Console.WriteLine("What is your name?");
            //string name = Convert.ToString(Console.ReadLine());
            //Console.WriteLine("When is your birthday (please use mm/dd/yy format)");
            //string bDay = Convert.ToString(Console.ReadLine());
            //Console.WriteLine("What is your favorite color?");
            //string color = Convert.ToString(Console.ReadLine());

            //string str = "Your name is " + name + " your birthday is " + bDay + " and your favorite color is " + color + "!!";
            //Console.WriteLine(str);
            //Console.WriteLine(str.ToUpper());
            //Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            sb.Append("Once upon a time. ");
            sb.Append("There was a girl who lived in a land far far away. ");
            sb.Append("She was trying to learn programming. ");
            sb.Append("She was hoping that she would be able to get a job in programming. ");
            sb.Append("However, she often felt as if she was not catching on to how it was done. ");
            sb.Append("Then after she googled what she needed to know. ");
            sb.Append("Then she figured it out and voila it worked.");

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
