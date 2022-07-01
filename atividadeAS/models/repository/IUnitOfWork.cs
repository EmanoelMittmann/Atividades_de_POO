using atividadeAS.models.repository;

namespace atividadeAS.models.repository
{
    public interface IUnitOfwork
    {
        Task CommitAsync();
        IAutorRepository AutorRepository{get;}
    }
}