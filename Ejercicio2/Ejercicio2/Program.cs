using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.Write("Ingrese el primer numero");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el segundo numero");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el tercer numero");
            c = Convert.ToInt32(Console.ReadLine());

            if(a > b && a > c)
            {
                Console.WriteLine("El numero mayor es: " + a);
                Console.ReadKey();
            }
            else if( b > a && b > c)
            {
                Console.WriteLine("El numero mayor es:  " + b);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("El numero mayor es:  " + c);
                Console.ReadKey();
            }

        }
    }
}
