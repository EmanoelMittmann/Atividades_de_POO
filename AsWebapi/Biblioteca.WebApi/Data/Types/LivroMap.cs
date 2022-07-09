using Biblioteca.WebApi.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Biblioteca.WebApi.Data.Types
{
    public class LivroMap : IEntityTypeConfiguration<Livro>
    {
        public void Configure(EntityTypeBuilder<Livro> builder)
        {
            builder.ToTable("livro");

            builder.Property(i => i.Id)
                .HasColumnName("id");

            builder.HasKey(i => i.Id);

            builder.Property(i => i.Titulo)
                .HasColumnName("titulo")
                .HasColumnType("VARCHAR")
                .HasMaxLength(80)
                .IsRequired();

            builder.Property(i => i.Volume)
                .HasColumnName("volume")
                .HasColumnType("INTEGER");

            builder.Property(i => i.EditoraId)
                .HasColumnName("editora_id")
                .HasColumnType("INTEGER")
                .IsRequired();

            builder.Property(i => i.GeneroId)
                .HasColumnName("genero_id")
                .HasColumnType("INTEGER")
                .IsRequired();


            //Relacionamentos

            builder.HasOne(x => x.Editora)
                .WithMany(x => x.Livros)
                .HasConstraintName("FK_Livro_Editora")
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.Genero)
                .WithMany(x => x.Livros)
                .HasConstraintName("FK_Livro_Genero")
                .OnDelete(DeleteBehavior.Restrict);

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
                        .OnDelete(DeleteBehavior.Restrict),
                    livro => livro
                        .HasOne<Livro>()
                        .WithMany()
                        .HasForeignKey("livro_id")
                        .HasConstraintName("FK_livro_autor_livro_id")
                        .OnDelete(DeleteBehavior.Restrict));
        }
    }
}