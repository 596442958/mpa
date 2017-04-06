using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace mpa.EntityFramework.Repositories
{
    public abstract class mpaRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<mpaDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected mpaRepositoryBase(IDbContextProvider<mpaDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class mpaRepositoryBase<TEntity> : mpaRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected mpaRepositoryBase(IDbContextProvider<mpaDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
