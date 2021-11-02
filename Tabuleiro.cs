using System;
using System.Collections.Generic;

namespace TabuleiroNamespace
{
    class Tabuleiro
    {
        private List<string> dadosTabuleiro = new List<string>();
        private int quantidadeTentativas;
        private bool fimTabuleiro;

        public Tabuleiro()
        {
            for (int i = 0; i < 25; i++)
            {
                this.dadosTabuleiro.Add("_");
            }
            this.dadosTabuleiro[0] = "|";
            this.quantidadeTentativas = 3;
            this.fimTabuleiro = false;
        }

        public void printTabuleiro()
        {
            string tabuleiro = "";
            foreach (string pos in dadosTabuleiro)
            {
                tabuleiro = tabuleiro + pos + " ";
            }
            Console.WriteLine(tabuleiro);
        }
    }
}

