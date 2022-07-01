using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using atividadeAS.models.Domain;
using Microsoft.EntityFrameworkCore;

namespace atividadeAS.models.repository
{
    public class LivroRepository : ILivroRepository
    {
        private Datacontext context;

        public LivroRepository(Datacontext context){
            this.context = context;
        }

        public void Create(Livro entity)
        {
            context.Add(entity);
        }

        public void Delete(int id)
        {
            var del = GetByIdAsync(id);
            context.Remove(del);
        }

        public async Task <List<Livro>> GetAll()
        {
            return await context.DbSetLivro.ToListAsync();
        }

        public void Update(Livro book)
        {
            context.Entry(book).State = EntityState.Modified;
        }

        public async Task<Livro> GetByIdAsync(int id)
        {
            return await context.DbSetLivro.SingleOrDefaultAsync(x => x.Id_Livro == id);
        }
    }

    public interface ILivroRepository
    {
        Task<List<Livro>> GetAll();
        void Create(Livro book);
        void Update(Livro book);
    }
}
