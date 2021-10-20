using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace converter_de_C_para_f
{
    class Program
    {
        static void Main(string[] args)
        {
            double f = 0;

            double c = 0;
            Console.WriteLine("Qual a temperatura em C°");
            c = double.Parse(Console.ReadLine());

            f = (double)(c * 9) / 5 + 32;
            Console.WriteLine("Temperatura convertida em F° é: " + f);
            Console.ReadKey();

        }
    }
}