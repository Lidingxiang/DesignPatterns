using SimpleAbsFactory.Service;
using SimpleAbsFactory.ServiceImpl;

namespace SimpleAbsFactory.ConcreteFactory
{
    public class SqlServerFactory : IFactory
    {
        public IUser CreateUser()
        {
            return new SqlServerUser();
        }

        public IDepartment CreateDepartment()
        {
            return new SqlServerDepartment();
        }
    }
}
