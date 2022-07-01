using atividadeAS.models.Domain;
namespace atividadeAS.models.repository
{
    public interface IEditoraRepository<Entity>
    where Entity:class
    {
        Task<Entity> GetByIdAsyn(int Id);
        Task <List<EditoraDomain>> GetAll();
        void Delete(int id);
        void Create(EditoraDomain entity);
    }
}