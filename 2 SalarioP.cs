using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salario_professor
{
    class Program
    {
        static void Main(string[] args)
        {

            float horaT, inss, insss, nHORAS, salarioB, desconto, salarioL;

            Console.WriteLine("Valor da hora trabalhada: ");
            horaT = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Percentual do INSS: ");
            insss = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Horas trabalhadas ao mês: ");
            nHORAS = Convert.ToInt16(Console.ReadLine());

            salarioB = horaT * nHORAS;
            Console.WriteLine("Valor do salario bruto: {0}", salarioB);
            

            inss = (insss / 100);
            desconto = inss * salarioB;

            salarioL = salarioB - desconto;
            Console.WriteLine("Valor do salario liquido:  {0}", salarioL);
            


            Console.WriteLine("Valor descontado:  {0}", desconto);
            Console.WriteLine("Pressione enter para continuar" );
            Console.ReadLine();
        }

    }
}