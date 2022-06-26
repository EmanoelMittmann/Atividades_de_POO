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
            builder.HasKey(user => user.Id_user);
            builder.Property(user => user.CPF).HasColumnType("varchar(11)");
            builder.Property(user => user.Nome).HasColumnType("varchar(50)");
            builder.Property(user => user.Email).HasColumnType("varchar(25)");
            builder.Property(user => user.Endereco).HasColumnType("varchar(50)");
            builder.Property(user => user.Telefone).HasColumnType("varchar(11)");
            
        }
    }
}