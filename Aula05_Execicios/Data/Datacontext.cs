using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Aula05_Execicios.Domain;

namespace Aula05_Execicios.Data
{
    public class Datacontext : DbContext
    {

        
        public Datacontext(DbContextOptions<Datacontext> options) : base(options)
        {

        }

        public DbSet<Contato> contatos {get; set;}

    }
}