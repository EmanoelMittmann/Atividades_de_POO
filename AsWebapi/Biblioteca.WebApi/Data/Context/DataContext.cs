using Biblioteca.WebApi.Data.Types;
using Biblioteca.WebApi.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace Biblioteca.WebApi.Data.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<Autor> Autores { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Editora> Editoras { get; set; }
        public DbSet<Emprestimo> Emprestimos { get; set; }
        public DbSet<Genero> Generos { get; set; }
        public DbSet<Livro> Livros { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AutorMap());
            modelBuilder.ApplyConfiguration(new ClienteMap());
            modelBuilder.ApplyConfiguration(new EditoraMap());
            modelBuilder.ApplyConfiguration(new EmprestimoMap());
            modelBuilder.ApplyConfiguration(new GeneroMap());
            modelBuilder.ApplyConfiguration(new LivroMap());
        }
    }
}