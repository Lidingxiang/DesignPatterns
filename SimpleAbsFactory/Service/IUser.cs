using SimpleAbsFactory.Model;

namespace SimpleAbsFactory.Service
{
    public interface IUser
    {
        void Insert(User user);

        User GetUser(int id);
    }
}
