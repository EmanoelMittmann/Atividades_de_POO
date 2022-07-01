using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using atividadeAS.models.Domain;
using Microsoft.EntityFrameworkCore;

namespace atividadeAS.models.repository
{
    public class EmprestimoRepository : IEmprestimoRespository
    {
        private Datacontext context;

        public EmprestimoRepository( Datacontext context)
        {
            this.context = context;
        }
        public void Create(Autor entity)
        {
            context.Add(entity);
        }

        public void Delete(int id)
        {
            var del = GetByIdAsync(id);
            context.Remove(del);
        }

        public async Task <List<Autor>> GetAll()
        {
            return await context.DbSetEmprestimo.ToListAsync();
        }

        public async Task<Autor> GetByIdAsync(int id)
        {
            return await context.DbSetEmprestimo.SingleOrDefaultAsync(x => x.Id_Autor == id);
        }
    }

}