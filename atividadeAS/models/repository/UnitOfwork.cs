using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using atividadeAS.models.repository;
namespace atividadeAS.models.repository
{
    public class UnitOfwork: IUnitOfwork
    {
        private readonly DataContext _data;

        public UnitOfwork(DataContext context)
        {
            this._data = context;
        }

        public async Task CommitAsync()
        {
            await _data.SaveChangesAsync();
        }

        private IAutorRepository _IAutor;

        public IAutorRepository AutorRepository
        {
            get{ return _IAutor ??= new AutorRepository(_data);}
        }

        private IUsuarioRepository _IUser;

        public IUsuarioRepository UserRepository
        {
            get{ return _IUser ??= new UsuarioRepository(_data);}
        }

        private ILivroRepository _IBook;

        public ILivroRepository LivroRepository
        {
            get{ return _IBook ??= new LivroRepository(_data);}
        }

        private IEmprestimoRespository _Iemprest;

        public IEmprestimoRespository EmprestimoRepository
        {
            get{ return _Iemprest ??= new EmprestimoRepository(_data);}
        }

        private IGeneroRepository _Igenero;

        public IGeneroRepository GeneroRepository
        {
            get{ return _Igenero ??= new GeneroRepository(_data);}
        }

        private IEditoraRepository _IEditora;

        public IEditoraRepository EditoraRepository
        {
            get{ return _IEditora ??= new EditoraRepository(_data);}
        }

        

    }
}