using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Configurations
{
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            // Configura o nome da tabela
            builder.ToTable("Cliente");

            // Configura a chave primária
            builder.HasKey(c => new { c.Id });

            // Configura o nome da coluna e seu tipo
            builder.Property(c => c.Id)
                .HasColumnName("CLI_ID")
                .IsRequired(); // Not Null

            builder.Property(c => c.Nome)
                .HasColumnName("CLI_NOME")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(c => c.DataNascimento)
                .HasColumnName("CLI_DATANASCIMENTO")
                .IsRequired();

            builder.Property(c => c.ClienteAtivo)
                .HasColumnName("CLI_ATIVO")
                .IsRequired();
        }
    }
}
