using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace DDDDemo.EntityFramework.Repositories
{
    public abstract class DDDDemoRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<DDDDemoDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected DDDDemoRepositoryBase(IDbContextProvider<DDDDemoDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class DDDDemoRepositoryBase<TEntity> : DDDDemoRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected DDDDemoRepositoryBase(IDbContextProvider<DDDDemoDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
