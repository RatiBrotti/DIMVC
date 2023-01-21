using DIMVC.DbClasses;

namespace DIMVC.DbAccess
{
    public interface IActivatedAccount
    {
        ActivatedAccount Add(ActivatedAccount activatedAccount);
        ActivatedAccount Edit(ActivatedAccount activatedAccount);
        ActivatedAccount Delete(int id);
        ActivatedAccount Get(int id);

        IEnumerable<ActivatedAccount> GetAll();
    }
}
