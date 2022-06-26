using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using atividadeAS.models.Domain;
using Microsoft.EntityFrameworkCore;

namespace atividadeAS.models.repository
{
    public class AutorRepository : IAutorRepository
    {
        private Datacontext contextAutor;

        public AutorRepository( Datacontext context)
        {
            this.contextAutor = context;
        }
        public void Create(Autor entity)
        {
            contextAutor.Add(entity);
        }

        public void Delete(int id)
        {
            var del = GetByIdAsync(id);
            contextAutor.Remove(del);
        }

        public async Task <List<Autor>> GetAll()
        {
            return await contextAutor.DbSetAutor.ToListAsync();
        }

        public async Task<Autor> GetByIdAsync(int id)
        {
            return await contextAutor.DbSetAutor.SingleOrDefaultAsync(x => x.Id_Autor == id);
        }
    }

    public interface IAutorRepository
    {
    }
}