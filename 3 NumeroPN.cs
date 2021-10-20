using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Positivonegativo
{
    class Program
    {
        static void Main(string[] args)
        {
            
        double algoritmo;
            Console.WriteLine("Digite um numero positivo ou negativo: ");
            algoritmo = Double.Parse(Console.ReadLine());
            if (algoritmo >= 0)
            {
                algoritmo = Math.Sqrt(algoritmo);
                Console.WriteLine("Numero positivo ! raiz quadrada é: {0}", algoritmo);
            }
            else
            {
                algoritmo = Math.Pow(algoritmo, 2);
                Console.WriteLine("Numero negativo valor elevado ao ² é: {0}", algoritmo);
            }
            Console.ReadLine();

        }
    }
}