using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using atividadeAS.models.Domain;
using Microsoft.EntityFrameworkCore;
using atividadeAS.Types;

namespace atividadeAS.models.repository
{
    public class DataContext : DbContext
    {

    public DataContext(DbContextOptions<DataContext> options): base(options)
    {
    }
     protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("DefaultConnection");
            }
    }

    public DbSet<Usuario> DbSetUser { get; set; }
    public DbSet<EmprestimoDomain> DbSetEmprest { get; set; } 
    public DbSet<EditoraDomain> DbSetEditora { get; set; } 
    public DbSet<Autor> DbSetAutor { get; set;} 
    public DbSet<Livro> DbSetLivro {get;set;} 
    public DbSet<Genero> DbSetGenero {get;set;}

    // protected override void OnModelCreating(ModelBuilder mbuild)
    // {
    //         mbuild.ApplyConfiguration(new TypeLivro());
    //         mbuild.ApplyConfiguration(new TypeAutor());
    //         mbuild.ApplyConfiguration(new TypeEmprestimo());
    //         mbuild.ApplyConfiguration(new TypeUsuario());
    //         mbuild.ApplyConfiguration(new TypeEditora());
    //         mbuild.ApplyConfiguration(new TypeGenero());
    // }
}
}