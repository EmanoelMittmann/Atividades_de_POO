namespace Biblioteca.WebApi.Domain.Interfaces
{
    public interface IUnitOfWork
    {
         Task CommitAsync();

         IAutorRepository AutorRepository {get;}
         IClienteRepository ClienteRepository {get;}
         IEditoraRepository EditoraRepository {get;}
         IEmprestimoRepository EmprestimoRepository {get;}
         IGeneroRepository GeneroRepository {get;}
         ILivroRepository LivroRepository {get;}
    }
}