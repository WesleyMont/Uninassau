using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salario
{
    class Program
    {
        static void Main(string[] args)
        {

            float horaT, VhoraT, salarioM, salariobruto, imposto, salariol;

            Console.WriteLine("Quantas horas trabalhadas? ");
            horaT = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qual o valor do salario minimo? ");
            salarioM = Convert.ToInt32(Console.ReadLine());

            VhoraT = Convert.ToInt32(salarioM / 2);
            Console.WriteLine("Valor da hora trabalhada é: {0}", VhoraT);

            salariobruto = horaT * VhoraT;
            Console.WriteLine("Valor do salariobruto: {0}", salariobruto);

            imposto = Convert.ToInt32(3 * salariobruto) / 100;
            Console.WriteLine("Valor descontado:  {0}", imposto);

            salariol = salariobruto - imposto;
            Console.WriteLine("Valor do salarioliquido: {0}", salariol);
            Console.WriteLine("Pressione Enter para continar");
            Console.ReadKey();

        }

    }
}
