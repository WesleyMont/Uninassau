using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Areadocirculo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            const double PI = 3.1415d;
            double raio = 0;
            double area = 0;

            
            Console.Write("Qual o raio do circulo : ");
            raio = double.Parse(Console.ReadLine());
            
            area = PI * (raio * raio);

            
            Console.Write("Área do Círculo é : " + area);
            
            Console.ReadKey();

        }
    }
}