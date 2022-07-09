using Biblioteca.WebApi.Data.Context;
using Biblioteca.WebApi.Domain.Entity;
using Biblioteca.WebApi.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Biblioteca.WebApi.Data.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly DataContext _context;
        public ClienteRepository(DataContext context)
        {
            this._context = context;
        }

        public bool Delete(int entityId)
        {
            var del = _context.Clientes.FirstOrDefault(i => i.Id == entityId);
            _context.Clientes.Remove(del);
            return true;
        }

        public async Task<IList<Cliente>> GetAllAsync()
        {
            return await _context.Clientes.ToListAsync();
        }

        public async Task<Cliente> GetByIdAsync(int entityId)
        {
            return await _context.Clientes.SingleOrDefaultAsync(x => x.Id == entityId);
        }

        public void Save(Cliente entity)
        {
            _context.Clientes.Add(entity);
        }

        public void Update(Cliente entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }

 
    }
}