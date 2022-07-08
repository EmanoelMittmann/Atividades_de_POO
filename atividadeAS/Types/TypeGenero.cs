using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using atividadeAS.models.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace atividadeAS.Types
{
    public class TypeGenero : IEntityTypeConfiguration<Genero>
    {
        public void Configure(EntityTypeBuilder<Genero> builder)
        {
            builder.ToTable("genero");
            builder.Property(genero => genero.Id_Genero)
                .HasColumnName("id_genero");
            builder.HasKey(genero => genero.Id_Genero);
            builder.Property(genero => genero.nome)
                .HasColumnType("NVARCHAR")
                .HasMaxLength(50);
        }
         
    }
}