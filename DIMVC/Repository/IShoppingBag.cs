using DIMVC.DbClasses;
namespace DIMVC.DbAccess
{
    public interface IShoppingBag
    {
        ShoppingBag Add(ShoppingBag bag);
        ShoppingBag Edit(ShoppingBag bag);
        ShoppingBag Delete(int id);
        ShoppingBag Get(int id);
        IEnumerable<ShoppingBag> GetAllShoppingBag();
    }
}
