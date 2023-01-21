using DIMVC.DbClasses;
using DIMVC.Context;
namespace DIMVC.DbAccess
{
    public class OrderRep : IOrder
    {
        private readonly ShContext _db;

        public OrderRep(ShContext db)
        {
            _db = db;
        }
        public Order Add(Order order)
        {
            _db.Add(order);
            _db.SaveChanges();
            return order;
        }

        public Order Delete(int id)
        {
            Order order = _db.Orders.Find(id);
            if (order != null)
            {
                _db.Orders.Remove(order);
                _db.SaveChanges();
            }
            return order;
        }

        public Order Get(int id)
        {
            return _db.Orders.Find(id);

        }

        public IEnumerable<Order> GetAll()
        {
            return _db.Orders;
        }

        public Order Edit(Order order)
        {
            _db.Update(order);
            _db.SaveChanges();
            return order;
        }
    }
}
