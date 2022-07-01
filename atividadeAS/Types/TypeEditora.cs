using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using atividadeAS.models.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace atividadeAS.Types
{
    public class TypeEditora : IEntityTypeConfiguration<EditoraDomain>
    {
        public void Configure(EntityTypeBuilder<EditoraDomain> builder)
        {
            builder.ToTable("editora");
            builder.Property(editora => editora.Id_Edit).HasColumnType("int");
            builder.Property(editora => editora.nome).HasColumnType("varchar(50)");
            builder.Property(editora => editora.cidade).HasColumnType("varchar(30)");
        }
    }
}