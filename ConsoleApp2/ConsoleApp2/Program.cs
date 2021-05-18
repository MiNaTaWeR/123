using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Введите оценку: ");
            int n = Convert.ToInt32(Console.ReadLine());
            switch (n)
            {
                case 1:Console.WriteLine("Оценка плохо");break;
                case 2: Console.WriteLine("Оценка неудовлетворительно"); break;
                case 3: Console.WriteLine("Оценка удовлетворительно"); break;
                case 4: Console.WriteLine("Оценка хорошо"); break;
                case 5: Console.WriteLine("Оценка отлично"); break;
                default: Console.WriteLine("Ошибка"); break;
            }
            Console.ReadKey();
            
        }
    }
}
