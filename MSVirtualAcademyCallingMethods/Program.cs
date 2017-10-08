using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSVirtualAcademyCallingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloWorld();

            string name = "Gabrielle";
            string reverseName = ReverseString(name);

            DisplayReverseResult(reverseName);

            DisplayReverseResult(name, reverseName);

            Console.ReadLine();
        }

        private static void HelloWorld()
        {
            Console.WriteLine("Hello, World!");
        }
        
        private static string ReverseString(string message)
        {
            char[] messageArray = message.ToCharArray();
            Array.Reverse(messageArray);

            return String.Concat(messageArray);
        }

        private static void DisplayReverseResult(string reverseName)
        {
            Console.WriteLine(reverseName);
        }

        //overriding method:
        //the parameters must be different (number or type)
        //the bodies can vary

        private static void DisplayReverseResult(string name, string reverseName)
        {
            Console.WriteLine(name);
            Console.WriteLine(reverseName);
        }

        //Bob recommends no more than 6 lines of code per method
        //not always possible to follow, but try
        //if your description of the method includes an "and"
        //it's doing more than one thing, so do another method too
    }
}
