using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using atividadeAS.models.Domain;
using Microsoft.EntityFrameworkCore;

namespace atividadeAS.models.repository
{
    public class usuarioRepository : IUsuarioRepository
    {
        private Datacontext context;

        public usuarioRepository(Datacontext context){
            this.context = context;
        }

        public void Create(Usuario entity)
        {
            context.Add(entity);
        }

        public void Delete(int id)
        {
            var del = GetByIdAsync(id);
            context.Remove(del);
        }

        public async Task <List<Usuario>> GetAll()
        {
            return await context.DbSetUser.ToListAsync();
        }

        public void Update(Usuario user)
        {
            context.Entry(user).State = EntityState.Modified;
        }

        public async Task<Usuario> GetByIdAsync(int id)
        {
            return await context.DbSetUser.SingleOrDefaultAsync(x => x.Id_user == id);
        }
    }

    public interface IUsuarioRepository
    {
    }
}