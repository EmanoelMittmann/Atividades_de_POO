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
        public void Create(EmprestimoDomain entity)
        {
            context.Add(entity);
        }

        public void Delete(int id)
        {
            var del = GetByIdAsync(id);
            context.Remove(del);
        }

        public async Task<List<EmprestimoDomain>> GetAll()
        {
            return await context.DbSetEmprest.ToListAsync();
        }

        public async Task<EmprestimoDomain> GetByIdAsync(int id)
        {
            return await context.DbSetEmprest.SingleOrDefaultAsync(x => x.Id_empres == id);
        }

        public void Update(EmprestimoDomain emprestimo)
        {
            throw new NotImplementedException();
        }
    }

    public interface IEmprestimoRespository
    {
        Task<List<EmprestimoDomain>> GetAll();
        void Create(EmprestimoDomain emprestimo);
        void Update(EmprestimoDomain emprestimo);
        
    }
}