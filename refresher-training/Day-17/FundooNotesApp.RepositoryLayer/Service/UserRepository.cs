using FundooNotesApp.ModelLayer.Entities;
using FundooNotesApp.ModelLayer.Models;
using FundooNotesApp.RepositoryLayer.Context;
using FundooNotesApp.RepositoryLayer.Interface;

namespace FundooNotesApp.RepositoryLayer.Service
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;

        // db context injected here
        public UserRepository(AppDbContext context)
        {
            _context = context;
        }

        public UserModel AddUser(UserEntity user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();

            // convert entity to model before returning
            return new UserModel
            {
                UserId = user.UserId,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email
            };
        }

        public UserEntity? GetUserByEmail(string email)
        {
            return _context.Users.FirstOrDefault(u => u.Email.ToLower() == email.ToLower());
        }

        public UserEntity? GetUserByResetToken(string token)
        {
            return _context.Users.FirstOrDefault(u => u.ResetToken == token);
        }

        public UserEntity UpdateUser(UserEntity user)
        {
            _context.Users.Update(user);
            _context.SaveChanges();
            return user;
        }
    }
}