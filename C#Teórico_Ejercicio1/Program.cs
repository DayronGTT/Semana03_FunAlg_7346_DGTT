using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Teórico_Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, Su;
            //Console.ReadKey();
            Console.Write("Ingrese el primer número: ");
            n1 = int.Parse(Console.ReadLine());
            
            Console.Write("Ingrese el segundo número: ");
            n2 = int.Parse(Console.ReadLine());

            Su = n1 + n2;
            Console.Write("La respuesta es "+Su);
        }
    }
}
