using DIMVC.DbClasses;
using DIMVC.Context;

namespace DIMVC.DbAccess
{
    public class ActivatedAccountRep : IActivatedAccount
    {
        private readonly ShContext _db;

        public ActivatedAccountRep(ShContext db)
        {
            _db = db;
        }

        public ActivatedAccount Add(ActivatedAccount activatedAccount)
        {
            _db.Add(activatedAccount);
            _db.SaveChanges();
            return activatedAccount;
        }

        public ActivatedAccount Delete(int id)
        {
            ActivatedAccount activatedaccount = _db.ActivatedAccounts.Find(id);
            if (activatedaccount != null)
            {
                _db.ActivatedAccounts.Remove(activatedaccount);
                _db.SaveChanges();
            }
            return activatedaccount;
        }

        public ActivatedAccount Get(int id)
        {
            return _db.ActivatedAccounts.Find(id);

        }

        public IEnumerable<ActivatedAccount> GetAll()
        {
            return _db.ActivatedAccounts;
        }

        public ActivatedAccount Edit(ActivatedAccount activatedAccount)
        {
            _db.Update(activatedAccount);
            _db.SaveChanges();
            return activatedAccount;
        }
    }
}
