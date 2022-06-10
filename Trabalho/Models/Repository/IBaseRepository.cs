namespace Trabalho.Models.Repository
{
    public interface IBaseRepository<Entity>
        where Entity: class
    {
        Entity GetById(int id);
        Task <List<Entity>> GetAll();
        void create(Entity entity);
        void Update(Entity entity);
        void Delete(int id);
    }
}