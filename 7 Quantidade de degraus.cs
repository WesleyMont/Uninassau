using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quantidade de escadas
{
    class Program
    {
        static void Main(string[] args)
        {

            float degrau, altura, qdegrau;
            Console.WriteLine ("Qal a altura da escada em 'Cm' ? ");
            altura = Convert.ToInt32(Console.ReadLine());


            
           Console.WriteLine ("Qual a altura dos degraus em 'Cm' ? ");
            degrau = Convert.ToInt32(Console.ReadLine());
            
            qdegrau = altura / degrau;
            
            Console.WriteLine ("A quantidade de degraus será: {0} ",qdegrau );
            
        
        }

    }
}