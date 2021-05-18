using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine()) % 10;
            Console.WriteLine(n * n % 10);
            Console.ReadKey();
        }
    }
}
