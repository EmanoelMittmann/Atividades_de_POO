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
        }

        public DbSet<Usuario> DbSetUser { get; set; }
        public DbSet<Emprestimo> DbSetEmprest { get; set; }
        public DbSet<EditoraDomain> DbSetEditora { get; set; }
        public DbSet<Autor> DbSetAutor { get; set;}
        public DbSet<Livro> DbSetLivro {get;set;}
        public DbSet<Genero> DbSetGenero {get;set;}
    }
}