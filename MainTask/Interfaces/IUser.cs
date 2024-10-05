using MainTask.Models;

namespace MainTask.Interfaces
{
    public interface IUser
    {
        void Register(User user);
        User Login(Login user);
        List<User> GetUsers();
    }
}
