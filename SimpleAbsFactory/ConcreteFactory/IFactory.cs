using SimpleAbsFactory.Service;

namespace SimpleAbsFactory.ConcreteFactory
{
    public interface IFactory
    {
        IUser CreateUser();

        IDepartment CreateDepartment();
    }
}
