using ReviewApp.Core.Abstraction.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewApp.Core.Abstraction.Repository
{
   public interface IRewiewUnitOfWork:IDisposable
    {
        //IRepositoryBase<TEntity> Repositorybase<TEntity>() where TEntity : class;

       public IPostRepository Posts { get;}
        // write all repository
        Task Commit();
    }
}
