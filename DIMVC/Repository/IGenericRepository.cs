using DIMVC.DbClasses;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace DIMVC.Repository
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        TEntity Add(TEntity entity);
        TEntity Edit(TEntity entity);
        TEntity Delete(int id);
        TEntity Get(int id);

        IEnumerable<TEntity> GetAll();
        int SaveChanges();

    }
}
