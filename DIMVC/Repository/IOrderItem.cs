using DIMVC.DbClasses;
namespace DIMVC.DbAccess
{
    public interface IOrderItem
    {
        OrderItem Add(OrderItem orderitem);
        OrderItem Edit(OrderItem orderitem);
        OrderItem Delete(int id);
        OrderItem Get(int id);

        IEnumerable<OrderItem> GetAll();

    }
}
