using DIMVC.DbClasses;
using DIMVC.Context;
namespace DIMVC.DbAccess
{
    public class ProductRep : IProduct
    {
        private readonly ShContext _db;
        public ProductRep(ShContext db)
        {
            _db = db;
        }
        public Product Add(Product product)
        {
            _db.Products.Add(product);
            _db.SaveChanges();
            return product;
        }

        public Product Delete(int id)
        {
            Product product= _db.Products.Find(id);
            if(product != null)
            {
                _db.Products.Remove(product);
                _db.SaveChanges();
                
            }
            return product;
        }

        public IEnumerable<Product> GetAll()
        {
            return _db.Products.ToList();
        }

        public Product Get(int id)
        {
            return _db.Products.Find(id);
        }

        public Product Edit(Product product)
        {
            _db.Update(product);
            _db.SaveChanges();
            return product;
        }
    }
}
