using DIMVC.Context;
using DIMVC.DbClasses;
using Microsoft.EntityFrameworkCore;

namespace DIMVC.Repository
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private readonly ShContext _db;
        private readonly DbSet<TEntity> dbSet;
        public GenericRepository(ShContext db)
        {
            _db = db;
            this.dbSet = _db.Set<TEntity>();
        }
        public TEntity Add(TEntity entity)
        {
            dbSet.Add(entity);
            return entity;
        }

        public TEntity Delete(int id)
        {
            var entity = dbSet.Find(id);
            if (entity != null)
            {
                dbSet.Remove(entity);
            }
            return entity;
        }

        public TEntity Get(int id)
        {
            return dbSet.Find(id);

        }

        public IEnumerable<TEntity> GetAll()
        {
            return dbSet;
        }

        public TEntity Edit(TEntity entity)
        {
            dbSet.Update(entity);
            return entity;
        }

        public int SaveChanges()
        {
            return _db.SaveChanges();
        }
    }
}
