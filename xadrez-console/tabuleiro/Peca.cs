using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabuleiro
{
    class Peca
    {
        public Posicao PosicaoObj { get; set; }
        public Cor CorObj { get; protected set; }
        public int QteMovimentosObj { get; protected set; }
        public Tabuleiro TabuleiroObj { get; protected set; }

        public Peca(Posicao posicaoObj, Cor corObj, Tabuleiro tabuleiroObj)
        {
            PosicaoObj = posicaoObj;
            CorObj = corObj;
            TabuleiroObj = tabuleiroObj;
            QteMovimentosObj = 0;
        }

       
    }
}
