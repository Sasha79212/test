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
            double x, y, z, k, d, c;

            z = Convert.ToDouble(Console.ReadLine());
            k = Convert.ToDouble(Console.ReadLine());
            d = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());

            if (z < 0)
            {
                x = Math.Pow(z, 2) - z ;
            }
            else
            {
                x = Math.Pow(z, 3) ;
            }

            y = Math.Pow(Math.Sin(Math.Pow(c * x + Math.Pow(d, 2) + k * Math.Pow(x, 2), 2)), 3) ;

            Console.WriteLine(y);
            Console.ReadKey();
        }
    }
}
