using FundooNotesApp.ModelLayer.Entities;
using FundooNotesApp.ModelLayer.Models;

namespace FundooNotesApp.RepositoryLayer.Interface
{
    public interface IUserRepository
    {
        // saves entity, returns plain model back
        UserModel AddUser(UserEntity user);

        // used for login and duplicate check
        UserEntity? GetUserByEmail(string email);

        // used for reset password flow
        UserEntity? GetUserByResetToken(string token);

        // updates entity, used for saving reset token or new password
        UserEntity UpdateUser(UserEntity user);
    }
}