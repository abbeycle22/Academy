using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Bran", "Rob", "Eddard", "Sonsa", "Riccon", "Arya", "Catlin" };

            Console.WriteLine("Last name of the family that lives at Winterfell?");
            string text = Console.ReadLine();

            Console.WriteLine("Here are the members of the " + text + " family:");
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i] + " " + text);
            }
            Console.ReadLine();
        }
    }
}
