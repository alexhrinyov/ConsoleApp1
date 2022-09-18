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
            Console.WriteLine((Semaphore.Red));

        }

        enum Semaphore:ushort
        {
            Red = 100, Yellow = 200, Green = 300
        }
    }
}
