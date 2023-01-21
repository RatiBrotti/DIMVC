using DIMVC.Models;

namespace DIMVC.Repository
{
    public interface ITestRepository

    {
        Test Add(Test t);
        Test Edit(Test t);
        Test Delete(Test t);
        Test Get(int id);
        IEnumerable<Test> GetAll();
    }
}
