namespace atividadeAS.models.repository
{
    public interface IUsuarioRepository<Entity>
        where Entity: class
    {
        Task<Entity> GetByIdAsync(int id);
        Task<List<Entity>> GetAll();
        void Create(Entity entity);
        void Update(Entity entity);
        void Delete(int id);
    }
}