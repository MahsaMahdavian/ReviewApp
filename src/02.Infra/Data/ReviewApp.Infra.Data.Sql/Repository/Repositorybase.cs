using Microsoft.EntityFrameworkCore;
using ReviewApp.Core.Abstraction.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;



namespace ReviewApp.Infra.Data.Sql.Repository
{
    public class Repositorybase<TEntity> : IRepositoryBase<TEntity> where TEntity : class 

    {
        private DbSet<TEntity> _dbSet;
    
        public Repositorybase(DbContext Context)
        {
            _dbSet = Context.Set<TEntity>();
        }
        public int CountEntities()
        {
            return _dbSet.Count();
        }

        public async Task CreateAsync(TEntity entity) => await _dbSet.AddAsync(entity);

        public async Task CreateRangeAsync(IEnumerable<TEntity> entities) => await _dbSet.AddRangeAsync(entities);


        public void Delete(TEntity entity)
        {
            _dbSet.Remove(entity);
        }

        public async Task<IEnumerable<TEntity>> FindAllAsync()
        {
            return  _dbSet.AsNoTracking().ToList();
        }

        public async Task<IEnumerable<TEntity>> FindByConditionAsync(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, params Expression<Func<TEntity, object>>[] includes)
        {
            IQueryable<TEntity> query = _dbSet;
            foreach (var include in includes)
            {
                query = query.Include(include);
            }

            if (filter != null)
            {
                query = query.Where(filter);
            }

            if (orderBy != null)
            {
                query = orderBy(query);
            }

            return await query.ToListAsync();
        }

        public async Task<TEntity> FindByIDAsync(object id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<List<TEntity>> GetPaginateResultAsync(int CurrentPage, int PageSize = 1)
        {
            var entities = await FindAllAsync();
            return entities.Skip((CurrentPage - 1) * PageSize).Take(PageSize).ToList();
        }

        public void Update(TEntity entity)
        {
            _dbSet.Update(entity);
        }
    }
}
