using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula11_crudPeople.Models.Repositories;
using Microsoft.EntityFrameworkCore;
using Aula11_crudPeople.Models.Domains;

namespace Aula11_crudPeople.Models.Repositories
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> opts)
            :base(opts)
        {}

        public DbSet<Person> People{get; set;}
       
    }
}