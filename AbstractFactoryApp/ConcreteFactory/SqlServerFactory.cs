using AbstractFactoryApp.Service;
using AbstractFactoryApp.ServiceImpl;

namespace AbstractFactoryApp.ConcreteFactory
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
