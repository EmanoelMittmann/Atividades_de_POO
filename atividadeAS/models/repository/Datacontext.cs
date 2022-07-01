using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using atividadeAS.models.Domain;
using atividadeAS.Types;
using Microsoft.EntityFrameworkCore;

namespace atividadeAS.models.repository
{
    public class Datacontext : DbContext
    {
        public Datacontext(DbContextOptions<Datacontext> opts)
            :base(opts)
        {}

        protected override void OnModelCreating(ModelBuilder mbuild)
        {
            mbuild.ApplyConfiguration(new TypeLivro());
            mbuild.ApplyConfiguration(new TypeAutor());
            mbuild.ApplyConfiguration(new TypeEmprestimo());
            mbuild.ApplyConfiguration(new TypeUsuario());
            mbuild.ApplyConfiguration(new TypeEditora());
            mbuild.ApplyConfiguration(new TypeGenero());
        }

        public DbSet<Usuario> DbSetUser { get; set; }
        public DbSet<EmprestimoDomain> DbSetEmprest { get; set; }
        public DbSet<EditoraDomain> DbSetEditora { get; set; }
        public DbSet<Autor> DbSetAutor { get; set;}
        public DbSet<Livro> DbSetLivro {get;set;}
        public DbSet<Genero> DbSetGenero {get;set;}
    }
}