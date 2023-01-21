using DIMVC.Models;

namespace DIMVC.Repository
{
    public class TestRepository : ITestRepository
    {
        private List<Test> _testList;
        public TestRepository()
        {
            _testList = new List<Test>()
            {
                 new Test { Id = 1, Name = "test", Description = "C# Dependency Injection" },
                 new Test {Id=2, Name="ASP>NET Core", Description="EF Core"}
            };
           
        }

            public Test Add(Test t)
        {
            throw new NotImplementedException();
        }

        public Test Delete(Test t)
        {
            throw new NotImplementedException();
        }

        public Test Edit(Test t)
        {
            throw new NotImplementedException();
        }

        public Test Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Test> GetAll()
        {

            return _testList;
        }
    }
}
