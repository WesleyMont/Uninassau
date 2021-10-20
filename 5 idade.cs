using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idade
{
    class Program
    {
        static void Main(string[] args)
        {
                
              float Ano, idade, futuro;
             
             Console.WriteLine("Em que ano você nasceu: ");
             Ano = Convert.ToInt16(Console.ReadLine());
             
             idade = 2021 - Ano;
             
             
             futuro = 2022 - Ano;
              
             Console.Write ("Você tem: {0} ", idade);
              Console.WriteLine ("anos");
             Console.Write ("Em 2022 você terá: {0} ", futuro);
             Console.WriteLine ("anos");
             
             Console.WriteLine("Pressione enter para continuar");
             Console.ReadLine();
        }       
     
    }
}