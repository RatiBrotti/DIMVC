using DIMVC.DbClasses;
using DIMVC.Context;
namespace DIMVC.DbAccess
{
    public class CategoryRep : ICategory
    {
        private readonly ShContext _db;

        public CategoryRep(ShContext db)
        {
            _db = db;
        }

        public Category Add(Category category)
        {
            _db.Add(category);
            _db.SaveChanges();
            return category;
        }

        public Category Delete(int id)
        {
            Category category= _db.Categories.Find(id);
            if (category != null)
            {
                _db.Categories.Remove(category);
                _db.SaveChanges();
            }
            return category;
        }

        public Category Get(int id)
        {
            return _db.Categories.Find(id);

        }

        public IEnumerable<Category> GetAll()
        {
            return _db.Categories;
        }

        public Category Edit(Category category)
        {
            _db.Update(category);
            _db.SaveChanges();
            return category;
        }
    }
}
