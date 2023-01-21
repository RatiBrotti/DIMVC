using DIMVC.DbClasses;
using DIMVC.Context;
namespace DIMVC.DbAccess
{
    public class OrderItemRep : IOrderItem
    {
        private readonly ShContext _db;

        public OrderItemRep(ShContext db)
        {
            _db = db;
        }

        public OrderItem Add(OrderItem orderitem)
        {
            _db.Add(orderitem);
            _db.SaveChanges();
            return orderitem;
        }

        public OrderItem Delete(int id)
        {
            OrderItem orderItem= _db.OrderItems.Find(id);
            if (orderItem != null)
            {
                _db.OrderItems.Remove(orderItem);
                _db.SaveChanges();
            }
            return orderItem;
        }

        public OrderItem Get(int id)
        {
            return _db.OrderItems.Find(id);

        }

        public IEnumerable<OrderItem> GetAll()
        {
            return _db.OrderItems;
        }

        public OrderItem Edit(OrderItem orderItem)
        {
            _db.Update(orderItem);
            _db.SaveChanges();
            return orderItem;
        }
    }
}
