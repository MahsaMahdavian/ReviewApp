using ReviewApp.Core.Abstraction.Repository;
using ReviewApp.Infra.Data.Sql.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewApp.Infra.Data.Sql.Common
{
    public class RewiewUnitOfWork : IUnitOfWork
    {
        public ReviewAppContext _Context { get; set; }
        public RewiewUnitOfWork(ReviewAppContext context)
        {
            _Context = context;
        }
        public async Task Commit()
        {
            await _Context.SaveChangesAsync();
        }

        public IRepositoryBase<TEntity> Repositorybase<TEntity>() where TEntity : class
        {
            IRepositoryBase<TEntity> repository = new Repositorybase<TEntity, ReviewAppContext>(_Context);
            return repository;
        }
    }
}
