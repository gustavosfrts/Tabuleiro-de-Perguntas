using System;
using System.Collections.Generic;

namespace Tabuleiro_de_Perguntas.Class
{
    class Tabuleiro
    {
        private List<string> dadosTabuleiro = new List<string>();
        private int quantidadeTentativas;
        private bool fimTabuleiro;

        public int getQuantidadeTentativas()
        {
            return this.quantidadeTentativas;
        }

        public bool getFimTabuleiro()
        {
            return this.fimTabuleiro;
        }

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

        public void andarCasas(int qtdCasas)
        {
            int casaAtual = this.dadosTabuleiro.IndexOf("|");
            if (casaAtual + qtdCasas < 24)
            {
                this.dadosTabuleiro[casaAtual] = "_";
                this.dadosTabuleiro[casaAtual+qtdCasas] = "|";
            } else
            {
                this.dadosTabuleiro[casaAtual] = "_";
                this.dadosTabuleiro[24] = "|";
                this.fimTabuleiro = true;
            }
        }

        public void descontarJogada()
        {
            this.quantidadeTentativas--;
            if(this.quantidadeTentativas == 0)
            {
                this.fimTabuleiro = true;
            }
        }
    }
}

