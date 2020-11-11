using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;

namespace xadrez_console
{
    class Program
    {
#pragma warning disable IDE0060 // Remove unused parameter
        static void Main(string[] args)
#pragma warning restore IDE0060 // Remove unused parameter
        {

            Tabuleiro tabuleiro = new Tabuleiro(8, 8);



            Posicao P = new Posicao(3, 4);


            Console.WriteLine("Posicao: " + P);

        }
    }
}
