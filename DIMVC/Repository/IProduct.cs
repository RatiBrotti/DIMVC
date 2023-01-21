using DIMVC.DbClasses;
namespace DIMVC.DbAccess
{
    public interface IProduct
    {
        Product Add(Product product);
        Product Edit(Product product);    
        Product Delete(int id);
        Product Get(int id);

        IEnumerable<Product> GetAll();
    }
}
