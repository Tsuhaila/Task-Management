using MainTask.Interfaces;
using MainTask.Models;

namespace MainTask.Services
{
  
    public class UserServices:IUser
    {
        List<User> users = new List<User>() 
        {
            new User{Id=1,UserName="admin",Password="123",Role="admin"},
            new User{Id=2,UserName="user",Password="123",Role="user"}
        };

        public void Register(User  user)
        {
            user.Id = users.Count + 1;
            users.Add(user);
        }

       public User Login(Login user)
        {
            var us=users.FirstOrDefault(x=>x.UserName==user.UserName && x.Password==user.Password);
            return us;
        }
        public List<User> GetUsers()
        {
            return users;
        }
    }
}
