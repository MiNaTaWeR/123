using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите оценку: ");
            int n = Convert.ToInt32(Console.ReadLine());
            switch (n)
            {
                case 1: Console.WriteLine("Февраль"); break;
                case 2: Console.WriteLine("Март"); break;
                case 3: Console.WriteLine("Апрель"); break;
                case 4: Console.WriteLine("Май"); break;
                case 5: Console.WriteLine("Июнь"); break;
                case 6: Console.WriteLine("Июль"); break;
                case 7: Console.WriteLine("Август"); break;
                case 8: Console.WriteLine("Сентябрь"); break;
                case 9: Console.WriteLine("Октябрь"); break;
                case 10: Console.WriteLine("Ноябрь"); break;
                case 11: Console.WriteLine("Декабрь"); break;
                case 12: Console.WriteLine("Январь"); break;

                default: Console.WriteLine("Ошибка"); break;
            }
            Console.ReadKey();
        }
    }
}
