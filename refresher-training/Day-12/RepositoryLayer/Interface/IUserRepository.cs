using ModelLayer.Entities;

namespace RepositoryLayer.Interface
{
    public interface IUserRepository
    {
        // adds new user
        User AddUser(User user);

        // finds user by email, used for login and duplicate check
        User? GetUserByEmail(string email);
    }
}