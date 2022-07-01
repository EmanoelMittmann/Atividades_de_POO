using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using atividadeAS.models.Domain;
using Microsoft.EntityFrameworkCore;

namespace atividadeAS.models.repository
{
    public class GeneroRepository:IGeneroRepository 
    {
        private Datacontext context;
        
        public GeneroRepository(Datacontext context){
          this.context = context;
        }

        public void Create(Genero entity){
            context.Add(entity);
        }

        public void Delete(int id){
            var del = GetByIdAsync(id);
            context.Remove(del);
        }

        public async Task <List<Genero>> GetAll(){
            return await context.DbSetGenero.ToListAsync();
        }

        public async Task<Genero> GetByIdAsync(int id){
            return await context.DbSetGenero.SingleOrDefaultAsync(x=>x.Id_Genero==id);
        }

        public void Update(Genero genero)
        {
            throw new NotImplementedException();
        }
    }

    public interface IGeneroRepository
    {
        Task<List<Genero>> GetAll();
        void Create(Genero genero);
        void Update(Genero genero);

    }
}