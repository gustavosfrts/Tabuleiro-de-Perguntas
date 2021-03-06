using Tabuleiro_de_Perguntas.Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace Tabuleiro_de_Perguntas.Data.Context
{
    public class MyContext : DbContext
    {
        public DbSet<PerguntasEntity> Perguntas { get; set; }
        public DbSet<RespostasEntity> Respostas { get; set; }
        public DbSet<JogadoresEntity> Jogadores { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost;Uid=sa;Password=projeto123;Database=TabuleiroPerguntas;MultipleActiveResultSets=True;");
        }
    }
}
