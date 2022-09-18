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
            
            const string MyName = "Jane";

            Console.WriteLine(MyName);

            Console.WriteLine("Привет, \nмир!");
            Console.WriteLine("Мне 27 лет");
            Console.WriteLine("\tМеня зовут Саша");
            Console.WriteLine("\x23");
            
            Console.WriteLine(0x0A);
            Console.WriteLine(0b11);
            Console.WriteLine(5.5);
            Console.ReadKey();
        }
    }
}
