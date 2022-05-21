using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Aula12_crudApi.Models.Domains;

namespace Aula12_crudApi.Models.Repository
{
    public class Datacontext : DbContext
    {
        public Datacontext(DbContextOptions<Datacontext> opts)
            :base(opts)
        {}

        public DbSet<DomainCliente> Cliente{get; set;}
    }
}