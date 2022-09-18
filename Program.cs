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
            Console.WriteLine((DaysOfWeak.Friday));

        }

        enum DaysOfWeak:byte
        {
            Sunday=1, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday
        }
    }
}
