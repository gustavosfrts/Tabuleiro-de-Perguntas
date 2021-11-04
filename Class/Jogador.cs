using System;

namespace Tabuleiro_de_Perguntas.Class
{
    class Jogador
    {
        private string nome;
        private int pontuacao;

        public string getNome(){
            return this.nome;
        }

        public void setNome(string nome){
            this.nome = nome;
        }

        public int getPontuacao(){
            return this.pontuacao;
        }

        public void setPontuacao(int pontuacao){
            this.pontuacao = pontuacao;
        }

        public void adicionarPontos(int pontos){
            this.pontuacao += pontos;
        }

        public void removerPontos(int pontos){
            this.pontuacao -= pontos;
        }

    }
}

