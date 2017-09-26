using AbstractFactoryApp.Service;

namespace AbstractFactoryApp.ConcreteFactory
{
    public interface IFactory
    {
        IUser CreateUser();

        IDepartment CreateDepartment();
    }
}
