using atividadeAS.models.Domain;

namespace atividadeAS.models.repository
{
    public interface IEmprestimoRespository<Entity>
        where Entity: class
    {
        Task<List<EmprestimoDomain>> GetAll();
        Task<EmprestimoDomain> GetByIdAsync();
        void Create(Entity entity);
        void Update(Entity entity);
        void Delete(int id);
        
    }
}