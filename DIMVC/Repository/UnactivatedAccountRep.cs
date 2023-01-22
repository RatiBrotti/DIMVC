using DIMVC.DbClasses;
using DIMVC.Context;

namespace DIMVC.Repository
{
    public class UnactivatedAccountRep : IUnactivatedAccount
    {
        private readonly ShContext _db;
        public UnactivatedAccountRep(ShContext db)
        {
            _db = db;

        }

        public UnactivatedAccount Add(UnactivatedAccount account)
        {
            _db.Add(account);
            _db.SaveChanges();
            return account;

        }

        public UnactivatedAccount Delete(int id)
        {
            UnactivatedAccount unactivatedAccount = _db.UnactivatedAccounts.Find(id);
            if (unactivatedAccount != null)
            {
                _db.UnactivatedAccounts.Remove(unactivatedAccount);
                _db.SaveChanges();
            }
            return unactivatedAccount;
        }

        public IEnumerable<UnactivatedAccount> GetAll()
        {
            //return _db.UnactivatedAccounts;

            return _db.UnactivatedAccounts;
        }

        public UnactivatedAccount Get(int id)
        {
            return _db.UnactivatedAccounts.Find(id);

        }

        public UnactivatedAccount Edit(UnactivatedAccount unactivatedaccount)
        {
            _db.Update(unactivatedaccount);
            _db.SaveChanges();
            return unactivatedaccount;
        }
    }
}
