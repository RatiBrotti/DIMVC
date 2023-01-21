using DIMVC.DbClasses;
using DIMVC.Context;
namespace DIMVC.DbAccess
{
    public class ShoppingBagRep : IShoppingBag
    {
        private readonly ShContext _db;
        public ShoppingBagRep(ShContext db)
        {
            _db = db;
        }

        public ShoppingBag Add(ShoppingBag bag)
        {
            _db.Add(bag);
            _db.SaveChanges();
            return bag;
        }

        public ShoppingBag Delete(int id)
        {
            ShoppingBag shoppingBag = _db.ShoppingBags.Find(id);
            if(shoppingBag != null)
            {
                _db.ShoppingBags.Remove(shoppingBag);
                _db.SaveChanges();
            }
            return shoppingBag;
        }

        public IEnumerable<ShoppingBag> GetAllShoppingBag()
        {
            return _db.ShoppingBags;
        }

        public ShoppingBag Get(int Id)
        {
            return _db.ShoppingBags.Find(Id);
        }

        public ShoppingBag Edit(ShoppingBag bag)
        {
            _db.Update(bag);
            _db.SaveChanges();
            return bag;
        }
    }
}
