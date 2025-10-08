using API_Tarefas.Data.Map;
using API_Tarefas.Models;
using Microsoft.EntityFrameworkCore;

namespace API_Tarefas.Data
{
    public class APITarefasDbContex : DbContext
    {
        public APITarefasDbContex(DbContextOptions options) : base(options)
        {
        }

        public DbSet<UsuarioModel> Usuarios { get; set; }
        public DbSet<TarefaModel> Tarefas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new TarefaMap());
            base.OnModelCreating(modelBuilder);
        }

        protected APITarefasDbContex()
        {
        }
    }
}
