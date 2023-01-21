using DIMVC.DbClasses;
namespace DIMVC.Repository
{
    public interface IUnactivatedAccount
    {
        UnactivatedAccount Add(UnactivatedAccount account);
        UnactivatedAccount Edit(UnactivatedAccount account);
        UnactivatedAccount Delete(int id);
        UnactivatedAccount Get(int id);

        IEnumerable<UnactivatedAccount> GetAll();
    }
}
