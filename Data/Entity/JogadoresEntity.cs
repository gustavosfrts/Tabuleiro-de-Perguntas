namespace Tabuleiro_de_Perguntas.Data.Entity
{
    public class JogadoresEntity
    {
        public int id { get; set; }
        public string nome_jogador { get; set; }
        public int pontos { get; set; }
        public string getNome(){
            return this.nome_jogador;
        }

        public void setNome(string nome){
            this.nome_jogador = nome;
        }

        public int getPontuacao(){
            return this.pontos;
        }

        public void setPontuacao(int pontuacao){
            this.pontos = pontuacao;
        }

        public void adicionarPontos(int pontos){
            this.pontos += pontos;
        }

        public void removerPontos(int pontos){
            this.pontos -= pontos;
        }
    }
}