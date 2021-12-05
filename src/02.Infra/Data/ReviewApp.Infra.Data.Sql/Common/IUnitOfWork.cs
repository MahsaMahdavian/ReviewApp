using ReviewApp.Core.Abstraction.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewApp.Infra.Data.Sql.Common
{
   public interface IUnitOfWork
    {
        IRepositoryBase<TEntity> Repositorybase<TEntity>() where TEntity : class;

        ReviewAppContext _Context { get; }
        Task Commit();
    }
}
