using DIMVC.DbClasses;
using DIMVC.Context;
namespace DIMVC.DbAccess
{
    public class AddressRep : IAddress
    {
        private readonly ShContext _db;

        public AddressRep(ShContext db)
        {
            _db = db;
        }


        public Address Add(Address address)
        {
            _db.Add(address);
            _db.SaveChanges();
            return address;
        }

        public Address Delete(int id)
        {
            Address address = _db.Addresses.Find(id);
            if(address != null)
            {
                _db.Addresses.Remove(address);
            }
            return address;
        }

        public Address Get(int id)
        {
            return _db.Addresses.Find(id);
        }

        public IEnumerable<Address> GetAll()
        {
            return _db.Addresses;
        }

        public Address Edit(Address address)
        {
            _db.Update(address);
            _db.SaveChanges();
            return address;
        }
    }
}
