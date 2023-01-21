using DIMVC.DbClasses;
namespace DIMVC.DbAccess
{
    public interface ICategory
    {
        Category Add(Category category);
        Category Edit(Category category);
        Category Delete(int id);
        Category Get(int id);

        IEnumerable<Category> GetAll();
    }
}
