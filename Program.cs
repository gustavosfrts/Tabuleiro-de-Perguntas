using System;
using Tabuleiro_de_Perguntas.Class;
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
            using (var context = new MyContext()){
                
                JogadoresEntity player = new JogadoresEntity();
                Tabuleiro tab = new Tabuleiro();
                bool continuar = true;
                while (continuar)
                {
                    Console.Clear();
                    Console.WriteLine("Olá! Seja muito bem vindo.");
                    Console.WriteLine("Insira o seu nome por gentileza >>.");
                    player.setNome(Console.ReadLine());
                    player.setPontuacao(0);
                    Console.WriteLine("Bem vindo ao jogo {0}. Vamos começar.", player.getNome());
                    while (!tab.getFimTabuleiro())
                    {
                        tab.printTabuleiro();
                        Console.WriteLine("Informe quantas casas deseja andar: ");
                        Console.WriteLine("A - 1 Casa");
                        Console.WriteLine("B - 2 Casas");
                        Console.WriteLine("C - 3 Casas");
                        string casa = Console.ReadLine().ToLower();
                        
                        while (casa != "a" && casa != "b" && casa != "c")
                        {
                            Console.WriteLine("Alternativa incorreta. Por favor, tente novamente.");
                            casa = Console.ReadLine().ToLower();
                        }

                        PerguntasEntity pergunta;
                        var respostas = context.Respostas.FromSqlRaw("select * from dbo.respostas");
                        int alternativa = 1;
                        string alternativaTexto;
                        string query;
                        switch (casa)
                        {
                            case "a":
                                pergunta = context.Perguntas.FromSqlRaw("select top 1 * from dbo.perguntas where nivel_pergunta = 1 order by NEWID()").FirstOrDefault();
                                Console.WriteLine(pergunta.pergunta);
                                query = "select * from dbo.respostas where id_perguntas = " + pergunta.id;
                                respostas = context.Respostas.FromSqlRaw(query);
                                foreach (var resposta in respostas.ToArray())
                                {
                                    alternativaTexto = alternativa + ". " + resposta.resposta;
                                    Console.WriteLine(alternativaTexto);
                                    alternativa++;
                                }
                                alternativa = int.Parse(Console.ReadLine());
                                
                                if (respostas.ToArray()[alternativa-1].resposta_certa)
                                {
                                    Console.WriteLine("Parabéns, você acertou!");
                                    player.adicionarPontos(2);
                                    tab.andarCasas(1);
                                    break;
                                }
                                Console.WriteLine("Você errou :(");
                                player.removerPontos(2);
                                tab.descontarJogada();
                                break;
                            
                            case "b":
                                pergunta = context.Perguntas.FromSqlRaw("select top 1 * from dbo.perguntas where nivel_pergunta = 2 order by NEWID()").FirstOrDefault();
                                Console.WriteLine(pergunta.pergunta);
                                query = "select * from dbo.respostas where id_perguntas = " + pergunta.id;
                                respostas = context.Respostas.FromSqlRaw(query);
                                foreach (var resposta in respostas.ToArray())
                                {
                                    alternativaTexto = alternativa + ". " + resposta.resposta;
                                    Console.WriteLine(alternativaTexto);
                                    alternativa++;
                                }
                                alternativa = int.Parse(Console.ReadLine());
                                
                                if (respostas.ToArray()[alternativa-1].resposta_certa)
                                {
                                    Console.WriteLine("Parabéns, você acertou!");
                                    player.adicionarPontos(4);
                                    tab.andarCasas(2);
                                    break;
                                }
                                Console.WriteLine("Você errou :(");
                                player.removerPontos(4);
                                tab.descontarJogada();
                                break;
                            
                            case "c":
                                pergunta = context.Perguntas.FromSqlRaw("select top 1 * from dbo.perguntas where nivel_pergunta = 3 order by NEWID()").FirstOrDefault();
                                Console.WriteLine(pergunta.pergunta);
                                query = "select * from dbo.respostas where id_perguntas = " + pergunta.id;
                                respostas = context.Respostas.FromSqlRaw(query);
                                foreach (var resposta in respostas.ToArray())
                                {
                                    alternativaTexto = alternativa + ". " + resposta.resposta;
                                    Console.WriteLine(alternativaTexto);
                                    alternativa++;
                                }
                                alternativa = int.Parse(Console.ReadLine());
                                
                                if (respostas.ToArray()[alternativa-1].resposta_certa)
                                {
                                    Console.WriteLine("Parabéns, você acertou!");
                                    player.adicionarPontos(8);
                                    tab.andarCasas(3);
                                    break;
                                }
                                Console.WriteLine("Você errou :(");
                                player.removerPontos(8);
                                tab.descontarJogada();
                                break;
                        }
                    }
                    
                    int pontos = (player.getPontuacao() < 0) ? 0 : player.getPontuacao();
                    player.setPontuacao(pontos);

                    context.Jogadores.Add(player);
                    context.SaveChanges();

                    var jogadores = context.Jogadores.FromSqlRaw("select top (5) * from dbo.jogadores order by pontos desc");
                    int ranking = 1;
                    Console.WriteLine("-------------------------------------------");
                    Console.WriteLine("5 Melhores jogadores de todos os tempos: ");
                    foreach (var jogador in jogadores.ToArray())
                    {
                        string infos = ranking + " - " + jogador.nome_jogador + " fez " + jogador.pontos + " pontos.";
                        Console.WriteLine(infos);
                        ranking++;
                    }

                    Console.WriteLine("Deseja jogar novamente?");
                    Console.WriteLine("1. Sim");
                    Console.WriteLine("2. Não");
                    string opcao = Console.ReadLine();
                    if (opcao == "2")
                    {
                        continuar = false;
                    }
                }
            }
        }
    }
}
