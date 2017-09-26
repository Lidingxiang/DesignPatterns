using AbstractFactoryApp.Model;

namespace AbstractFactoryApp.Service
{
    public interface IUser
    {
        void Insert(User user);

        User GetUser(int id);
    }
}
