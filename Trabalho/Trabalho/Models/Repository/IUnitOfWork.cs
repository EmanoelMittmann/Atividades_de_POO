namespace Trabalho.Models.Repository
{
    public interface IUnitOfWork
    {
        Task CommitAsync();
        IRepositoryBank RepositoryBank{get;}
    }

}