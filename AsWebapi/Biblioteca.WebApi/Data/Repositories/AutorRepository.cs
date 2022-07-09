using Biblioteca.WebApi.Data.Context;
using Biblioteca.WebApi.Domain.Entity;
using Biblioteca.WebApi.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Biblioteca.WebApi.Data.Repositories
{
    public class AutorRepository : IAutorRepository
    {
        private readonly DataContext _context;
        public AutorRepository(DataContext context)
        {
            this._context = context;
        }

        public bool Delete(int entityId)
        {
            var del = _context.Autores.FirstOrDefault(i => i.Id == entityId);
            _context.Autores.Remove(del);
            return true;
        }

        public async Task<IList<Autor>> GetAllAsync()
        {
            return await _context.Autores.ToListAsync();
        }

        public async Task<Autor> GetByIdAsync(int entityId)
        {
            return await _context.Autores.SingleOrDefaultAsync(x => x.Id == entityId);
        }

        public void Save(Autor entity)
        {
            _context.Autores.Add(entity);
        }

        public void Update(Autor entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }
    }
}