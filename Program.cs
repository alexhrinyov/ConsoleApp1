using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            const string myName = "Alexandr";
            byte age = 29;
            bool pet = false;
            float shoe_size = 42;
            Console.WriteLine("My name is {0}", myName);
            Console.WriteLine("My age is {0}", age);
            Console.WriteLine("Do you have a pet?");
            if (pet == true)
                Console.WriteLine("Yes, I have a pet");
            else
                Console.WriteLine("No, I don't");
            Console.WriteLine("My shoe size is {0}", shoe_size);
            Console.ReadKey();
        }
    }
}
