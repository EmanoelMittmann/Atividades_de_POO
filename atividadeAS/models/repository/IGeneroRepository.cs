using atividadeAS.models.Domain;
namespace atividadeAS.models.repository
{
    public interface IGeneroRepository<Entity>
    where Entity:class
    {
        Task<Entity> GetByIdAsync(int Id);
        Task <List<Entity>> GetAll();
        void Delete(int id);
        void Create(Entity entity);
    }
}
