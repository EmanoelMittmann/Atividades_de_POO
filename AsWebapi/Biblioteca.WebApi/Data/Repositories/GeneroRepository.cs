using Biblioteca.WebApi.Data.Context;
using Biblioteca.WebApi.Domain.Entity;
using Biblioteca.WebApi.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Biblioteca.WebApi.Data.Repositories
{
    public class GeneroRepository : IGeneroRepository
    {
        private readonly DataContext _context;
        public GeneroRepository(DataContext context)
        {
            this._context = context;
        }

        public bool Delete(int entityId)
        {
            var del = _context.Generos.FirstOrDefault(i => i.Id == entityId);
            _context.Generos.Remove(del);
            return true;
        }

        public async Task<IList<Genero>> GetAllAsync()
        {
            return  await _context.Generos.ToListAsync();
        }

        public async Task<Genero> GetByIdAsync(int entityId)
        {
            return await _context.Generos.SingleOrDefaultAsync(x => x.Id == entityId);
        }

        public void Save(Genero entity)
        {
            _context.Generos.Add(entity);
        }

        public void Update(Genero entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }

    }
}