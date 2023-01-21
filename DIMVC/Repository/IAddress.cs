using DIMVC.DbClasses;
namespace DIMVC.DbAccess
{
    public interface IAddress
    {
        Address Add(Address address);
        Address Edit(Address address);
        Address Delete(int id);    
        Address Get(int id);

        IEnumerable<Address> GetAll();
    }
}
