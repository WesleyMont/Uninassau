using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int teste;
        Console.WriteLine("Qual presente você quer ?");
        Console.WriteLine("Digite 1 para PS4, 2 para XboX One S");
        Console.WriteLine("3 para Nitendo Switch e 4 Para PC Gamer");
        teste = int.Parse(Console.ReadLine());
        switch (teste)
        {
            case 1: Console.WriteLine("PS4"); break;
            case 2: Console.WriteLine("XboX One S"); break;
            case 3: Console.WriteLine("Nitendo switch"); break;
            case 4: Console.WriteLine("PC Gamer"); break;

        }
        Console.ReadKey();
    }
}