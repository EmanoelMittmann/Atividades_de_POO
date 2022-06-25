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

        public void Create(Bank entity)
        {
            context.Add(entity);
        }

        public void Delete(int id)
        {
            var del = GetByIdAsync(id);
            context.Remove(del);
        }
        public async Task <List<Bank>> GetAll()
        {
            return  await context.DbSetBank.ToListAsync();
        }
        public void Update(Bank bank)
        {
            context.Entry(bank).State = EntityState.Modified;
        }

        public async Task<Bank> GetByIdAsync(int id)
        {
            return await context.DbSetBank.SingleOrDefaultAsync(x => x.Id_bank == id);

        }
    }

}