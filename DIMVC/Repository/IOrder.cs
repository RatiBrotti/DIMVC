using DIMVC.DbClasses;
namespace DIMVC.DbAccess
{
    public interface IOrder
    {
        Order Add(Order order);
        Order Edit(Order order);
        Order Delete(int id);
        Order Get(int id);

        IEnumerable<Order> GetAll();
    }
}
