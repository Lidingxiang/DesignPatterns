using SimpleAbsFactory.Service;
using SimpleAbsFactory.ServiceImpl;

namespace SimpleAbsFactory.ConcreteFactory
{
    public class AccessFactory : IFactory
    {
        public IUser CreateUser()
        {
            return new AccessUser();
        }

        public IDepartment CreateDepartment()
        {
            return new AccessDepartment();
        }
    }
}
