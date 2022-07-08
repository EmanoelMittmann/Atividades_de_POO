using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using atividadeAS.models.Domain;
using Microsoft.EntityFrameworkCore;

namespace atividadeAS.models.repository
{
    public class EditoraRepository:IEditoraRepository 
    {
        private DataContext context;
        
        public EditoraRepository(DataContext context){
          this.context = context;
        }

        public void Create(EditoraDomain entity){
            context.Add(entity);
        }

        public void Delete(int id){
            var del = GetByIdAsync(id);
            context.Remove(del);
        }

        public async Task <List<EditoraDomain>> GetAll(){
            return await context.DbSetEditora.ToListAsync();
        }

        public async Task<EditoraDomain> GetByIdAsync(int id){
            return await context.DbSetEditora.SingleOrDefaultAsync(x=>x.Id_Edit==id);
        }

        public void Update(EditoraDomain edit)
        {
            throw new NotImplementedException();
        }
    }

    public interface IEditoraRepository
    {
        Task<List<EditoraDomain>> GetAll();
        void Create(EditoraDomain edit);
        void Update(EditoraDomain edit);
    }
}