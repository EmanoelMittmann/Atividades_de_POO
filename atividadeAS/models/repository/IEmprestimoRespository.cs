namespace atividadeAS.models.repository
{
    public interface IEmprestimoRepository<entity>
    where Entity : class
    {
        Task<Entity> GetByIdAsync(int id);
        Task<List<Entity>> GetAll();
        void Create(Entity entity);
        void Delete(int id);
        void Update(Entity entity);
    }
}

