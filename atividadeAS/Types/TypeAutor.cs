using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using atividadeAS.models.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace atividadeAS.Types
{
    public class TypeAutor : IEntityTypeConfiguration<Autor>
    {
        public void Configure(EntityTypeBuilder<Autor> builder)
        {
            builder.ToTable("autor");
            builder.HasKey(autor => autor.Id_Autor);
            builder.Property(autor => autor.Nome).HasColumnType("varchar(50)"); 
            
        }
    }
}