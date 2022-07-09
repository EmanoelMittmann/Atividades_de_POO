using Biblioteca.WebApi.Data.Context;
using Biblioteca.WebApi.Domain.Entity;
using Biblioteca.WebApi.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Biblioteca.WebApi.Data.Repositories
{
    public class EmprestimoRepository : IEmprestimoRepository
    {
        private readonly DataContext _context;
        public EmprestimoRepository(DataContext context)
        {
            this._context = context;
        }

        public bool Delete(int entityId)
        {
            var del = _context.Emprestimos.FirstOrDefault(i => i.Id == entityId);
            _context.Emprestimos.Remove(del);
            return true;
        }

        public async Task<IList<Emprestimo>> GetAllAsync()
        {
            return await _context.Emprestimos.ToListAsync();
        }

        public async Task<Emprestimo> GetByIdAsync(int entityId)
        {
            return await _context.Emprestimos.SingleOrDefaultAsync(x => x.Id == entityId);
        }

        public void Save(Emprestimo entity)
        {
            _context.Emprestimos.Add(entity);
        }

        public void Update(Emprestimo entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }

    }
}