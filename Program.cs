using System;
using JogadorNamespace;
using TabuleiroNamespace;

namespace Tabuleiro_de_Perguntas
{
    class Program
    {
        static void Main(string[] args)
        {
            Jogador player = new Jogador();
            Tabuleiro tab = new Tabuleiro();
            tab.printTabuleiro();
        }
    }
}
