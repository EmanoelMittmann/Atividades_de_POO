using Biblioteca.WebApi.Data.Context;
using Biblioteca.WebApi.Domain.Interfaces;

namespace Biblioteca.WebApi.Data.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _context;

        public UnitOfWork(DataContext context)
        {
            this._context = context;
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }
        
        private IAutorRepository _AutorRepository;

        private IClienteRepository _ClienteRepository;

        private IEditoraRepository _EditoraRepository;

        private IEmprestimoRepository _EmprestimoRepository;

        private IGeneroRepository _GeneroRepository;

        private ILivroRepository _LivroRepository;

        public IAutorRepository AutorRepository
        {
            get { return _AutorRepository ??= new AutorRepository(_context);}
        }

        public IClienteRepository ClienteRepository
        {
            get { return _ClienteRepository ??= new ClienteRepository(_context);}
        }

        public IEditoraRepository EditoraRepository
        {
            get { return _EditoraRepository ??= new EditoraRepository(_context);}
        }

        public IEmprestimoRepository EmprestimoRepository
        {
            get { return _EmprestimoRepository ??= new EmprestimoRepository(_context);}
        }

        public IGeneroRepository GeneroRepository
        {
            get { return _GeneroRepository ??= new GeneroRepository(_context);}
        }

        public ILivroRepository LivroRepository
        {
            get { return _LivroRepository ??= new LivroRepository(_context);}
        }
    }
}