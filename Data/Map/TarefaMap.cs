using API_Tarefas.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API_Tarefas.Data.Map
{
    public class TarefaMap : IEntityTypeConfiguration<TarefaModel>
    {
        public void Configure(EntityTypeBuilder<TarefaModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).IsRequired().HasMaxLength(120);
            builder.Property(x => x.Descricao).HasMaxLength(500);
            builder.Property(x => x.Status).IsRequired();
            builder.Property(x => x.UsuarioID);
            builder.HasOne(x => x.Usuario);   //Criando um vinculo
        }
    }
}
