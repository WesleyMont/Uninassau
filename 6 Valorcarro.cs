using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valorcarro
{
    class Program
    {
        static void Main(string[] args)
        {

            float fabrica, pimpostos, impostos, distribuidora, valort, Vimpostos, Vdistriuidora, Tdistribuidora;

            Console.WriteLine("Valor da fabrica: ");
            fabrica = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Percentual dos impostos: ");
            impostos = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("pescentual da Distriuidora: ");
            distribuidora = Convert.ToInt16(Console.ReadLine());

            pimpostos = (impostos / 100);
            Vimpostos = pimpostos * fabrica;

            Console.WriteLine("Valor dos impostos:  {0}", Vimpostos);
            Tdistribuidora = (distribuidora / 100);
            Vdistriuidora = Tdistribuidora * fabrica;

            Console.WriteLine("Valor descontado:  {0}", Vdistriuidora);

            valort = fabrica + Vdistriuidora + Vimpostos;
            Console.WriteLine("Valor total: {0}", valort);

            Console.WriteLine("Pressione enter para continuar");
            Console.ReadLine();
        }

    }
}