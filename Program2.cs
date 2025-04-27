using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void task4()
        {
            int num;

            num = Convert.ToInt16(Console.ReadLine());

            switch (num)
            {
                case 1: Console.WriteLine("Плохо"); break;
                case 2: Console.WriteLine("Неудовлетворительно"); break;
                case 3: Console.WriteLine("Удовлетворительно"); break;
                case 4: Console.WriteLine("Хорошо"); break;
                case 5: Console.WriteLine("Отлично"); break;
                default: Console.WriteLine("Введено не правильное число"); break;
            }

            Console.ReadKey();
        }


        static void task5()
        {
            int a, b, num ;

            a = Convert.ToInt16(Console.ReadLine());
            b = Convert.ToInt16(Console.ReadLine());
            num = Convert.ToInt16(Console.ReadLine());
            

            switch (num)
            {
                case 1: Console.WriteLine(a+b); break;
                case 2: Console.WriteLine(a-b); break;
                case 3: Console.WriteLine(a*b); break;
                case 4: Console.WriteLine(a/b); break;
            }

            Console.ReadKey();
        }


        static void task6()
        {
            int a, b, c, d;

            c = Convert.ToInt16(Console.ReadLine());

            a = c % 10;

            b = a * a;


            switch (d)
            {
                d: Console.WriteLine (b % 10);
            }

            Console.ReadKey();

        }


        static void Main(string[] args)
        {
            task6();
        }
    }
}
