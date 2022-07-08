using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using atividadeAS.models.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace atividadeAS.Types
{
    public class TypeUsuario : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("user");
            builder.Property(user => user.Id_user)
                .HasColumnName("Id_user");
            builder.HasKey(user => user.Id_user);
            builder.Property(user => user.CPF)
                .HasColumnName("CPF")
                .HasColumnType("NVARCHAR")
                .HasMaxLength(50);
            builder.Property(user => user.Nome)
                .HasColumnName("Nome")
                .HasColumnType("NVARCHAR")
                .HasMaxLength(30);
            builder.Property(user => user.Email)
                .HasColumnName("Email")
                .HasColumnType("NVARCHAR")
                .HasMaxLength(30);
            builder.Property(user => user.Endereco)
                .HasColumnName("Endereco")
                .HasColumnType("NVARCHAR")
                .HasMaxLength(30);
            builder.Property(user => user.Telefone)
                .HasColumnName("Telefone")
                .HasColumnType("NVARCHAR")
                .HasMaxLength(11);
            
        }
    }
}