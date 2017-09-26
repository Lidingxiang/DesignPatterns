using SimpleAbsFactory.Model;

namespace SimpleAbsFactory.Service
{

    public interface IDepartment
    {
        void Insert(Department department);

        Department GetDepartment(int id);
    }
}
