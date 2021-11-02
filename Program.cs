using System;
using JogadorNamespace;
using TabuleiroNamespace;
using Tabuleiro_de_Perguntas.Data.Entity;
using Tabuleiro_de_Perguntas.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Tabuleiro_de_Perguntas
{
    class Program
    {
        static void Main(string[] args)
        {
            Jogador player = new Jogador();
            Tabuleiro tab = new Tabuleiro();
            tab.printTabuleiro();

            using (var context = new MyContext()){
                var respostas = context.Respostas.FromSqlRaw("select top 1 * from dbo.respostas order by NEWID()").FirstOrDefault();
                Console.WriteLine(respostas.resposta);
            }
        }
    }
}
