using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using atividadeAS.models.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace atividadeAS.Types
{
    public class TypeLivro : IEntityTypeConfiguration<Livro>
    {
        public void Configure(EntityTypeBuilder<Livro> builder)
        {
            builder.ToTable("Livro");
            builder.Property(Livro => Livro.Id_Livro)
                .HasColumnName("Id_Livro");
            builder.HasKey(Livro => Livro.Id_Livro);
            builder.Property(Livro => Livro.Titulo)
                .HasColumnName("Titulo")
                .HasColumnType("NVARCHAR")
                .HasMaxLength(50);
            builder.Property(Livro => Livro.Num_edit)
                .HasColumnName("Numero_editacao")
                .HasColumnType("INTEGER");
            builder.Property(Livro => Livro.Volume).HasColumnType("INTEGER");

            // Relacionamentos um pra muitos

            builder.HasOne(x => x.Genero)
                .WithMany(x => x.Livros)
                .HasConstraintName("FK_Livro_Genero")
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.Editora)
                .WithMany(x => x.Livros)
                .HasConstraintName("FK_Livro_Editora")
                .OnDelete(DeleteBehavior.Restrict);

            //Relacionamento muito pra muitos

            builder
                .HasMany(i => i.Autores)
                .WithMany(i => i.Livros)
                .UsingEntity<Dictionary<string, object>>(
                    "livro_autor",
                    autor => autor
                        .HasOne<Autor>()
                        .WithMany()
                        .HasForeignKey("autor_id")
                        .HasConstraintName("FK_livro_autor_autor_id")
                        .OnDelete(DeleteBehavior.Cascade),
                    livro => livro
                        .HasOne<Livro>()
                        .WithMany()
                        .HasForeignKey("livro_id")
                        .HasConstraintName("FK_livro_autor_livro_id")
                        .OnDelete(DeleteBehavior.Cascade));
        }
    }
}