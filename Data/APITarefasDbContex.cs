using Microsoft.EntityFrameworkCore;
using API_Tarefas.Models;

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
            base.OnModelCreating(modelBuilder);
        }

        protected APITarefasDbContex()
        {
        }
    }
}
