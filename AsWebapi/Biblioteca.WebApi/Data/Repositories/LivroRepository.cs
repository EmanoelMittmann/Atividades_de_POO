using Biblioteca.WebApi.Data.Context;
using Biblioteca.WebApi.Domain.Entity;
using Biblioteca.WebApi.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Biblioteca.WebApi.Data.Repositories
{
    public class LivroRepository : ILivroRepository
    {
        private readonly DataContext _context;
        public LivroRepository(DataContext context)
        {
            this._context = context;
        }

        public bool Delete(int entityId)
        {
            var del = _context.Livros.FirstOrDefault(i => i.Id == entityId);
            _context.Livros.Remove(del);
            return true;
        }

        public async Task<IList<Livro>> GetAllAsync()
        {
           return await _context.Livros.ToListAsync();
        }

        public async Task<Livro> GetByIdAsync(int entityId)
        {
            return await _context.Livros.SingleOrDefaultAsync(x => x.Id == entityId);
        }

        public void Save(Livro entity)
        {
            _context.Livros.Add(entity);
        }

        public void Update(Livro entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }
    }
}