using Data.Entities;
using Data.Repositories.Interfaces;

namespace Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly GarageContext _context;

        public UserRepository(GarageContext context)
        {
            _context = context;
        }
        public User? ValidateUser(string username, string password)
        {
            return _context.Users.FirstOrDefault(u => u.IsActive == true && u.UserName == username && u.Password == password);
            //además de checkear el username y el password me fijo que sea active
        }

        public User? GetUserByUserName(string userName)
        {
            return _context.Users.FirstOrDefault(u => u.UserName == userName);
        }
    }
}
