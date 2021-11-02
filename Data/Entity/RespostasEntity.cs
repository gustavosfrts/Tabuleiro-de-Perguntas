namespace Tabuleiro_de_Perguntas.Data.Entity
{
    public class RespostasEntity
    {
        public int id { get; set; }
        public int id_perguntas { get; set; }
        public string resposta { get; set; }
        public bool resposta_certa { get; set; }
    }
}