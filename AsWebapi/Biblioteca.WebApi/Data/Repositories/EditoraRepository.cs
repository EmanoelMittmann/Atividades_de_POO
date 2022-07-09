using Biblioteca.WebApi.Data.Context;
using Biblioteca.WebApi.Domain.Entity;
using Biblioteca.WebApi.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Biblioteca.WebApi.Data.Repositories
{
    public class EditoraRepository : IEditoraRepository
    {
        private readonly DataContext _context;
        public EditoraRepository(DataContext context)
        {
            this._context = context;
        }

        public bool Delete(int entityId)
        {
            var del = _context.Editoras.FirstOrDefault(i => i.Id == entityId);
            _context.Editoras.Remove(del);
            return true;
        }

        public async Task<IList<Editora>> GetAllAsync()
        {
           return await _context.Editoras.ToListAsync();
        }

        public async Task<Editora> GetByIdAsync(int entityId)
        {
            return await _context.Editoras.SingleOrDefaultAsync(x => x.Id == entityId); 
        }

        public void Save(Editora entity)
        {
            _context.Editoras.Add(entity);
        }

        public void Update(Editora entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }

    }
}