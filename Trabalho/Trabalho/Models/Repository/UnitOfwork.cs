using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trabalho.Models.Repository
{
    public class UnitOfwork: IUnitOfWork
    {
        private readonly Datacontext _data;

        public UnitOfwork(Datacontext context)
        {
            this._data = context;
        }

        public async Task CommitAsync()
        {
            await _data.SaveChangesAsync();
        }

        private IRepositoryBank _IBank;

        public IRepositoryBank RepositoryBank
        {
            get { return _IBank ??= new RepositoryBank(_data);}
        }

    }

}