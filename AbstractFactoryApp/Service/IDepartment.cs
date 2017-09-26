using AbstractFactoryApp.Model;

namespace AbstractFactoryApp.Service
{

    public interface IDepartment
    {
        void Insert(Department department);

        Department GetDepartment(int id);
    }
}
