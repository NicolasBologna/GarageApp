using Data.Entities;

namespace Data.Repositories.Interfaces
{
    public interface IUserRepository
    {
        User? GetUserByUserId(int id);
        User? GetUserByUserName(string userName);
        User ValidateUser(string username, string password);
    }
}