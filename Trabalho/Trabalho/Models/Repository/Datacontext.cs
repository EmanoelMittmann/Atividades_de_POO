using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Trabalho.Models.Domain;
using Trabalho.Types;

namespace Trabalho.Models.Repository
{
    public class Datacontext : DbContext
    {
        public Datacontext(DbContextOptions<Datacontext> opts)
            :base(opts)
        {}
        
        protected override void OnModelCreating(ModelBuilder mbuild)
        {
            mbuild.ApplyConfiguration(new TypeBank());
        }
        public DbSet<Bank> DbSetBank{ get; set; } 
        
    }
}