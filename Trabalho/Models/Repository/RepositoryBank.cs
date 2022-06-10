using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Trabalho.Models.Domain;


namespace Trabalho.Models.Repository
{
    public class RepositoryBank:IRepositoryBank
    {
        private Datacontext context;

        public RepositoryBank(Datacontext context){
            this.context = context;
        }

        public Bank GetById(int id)
        {
            return context.DbSetBank.SingleOrDefault(Bank => Bank.Id_bank == id);
        }

        public void Create(Bank entity)
        {
            context.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var del = GetById(id);
            context.Remove(del);
            context.SaveChanges();
        }
        public async Task <List<Bank>> GetAll()
        {
            return  await context.DbSetBank.ToListAsync();
        }
        public void Update(Bank bank)
        {
            context.DbSetBank.Update(bank);
            context.SaveChanges();
        }

        public void create(Bank entity)
        {
            throw new NotImplementedException();
        }
    }

}