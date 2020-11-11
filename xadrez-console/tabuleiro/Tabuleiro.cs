using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabuleiro
{
    class Tabuleiro
    {
        public int Linhas { get; set; }
        public int Colunas { get; set; }

#pragma warning disable IDE0052 // Remove unread private members
        private readonly Peca[,] PecasObj;
#pragma warning restore IDE0052 // Remove unread private members

        public Tabuleiro(int linhas, int colunas)
        {
            this.Linhas = linhas;
            this.Colunas = colunas;
            PecasObj = new Peca[linhas, colunas];

        }
    }
}
