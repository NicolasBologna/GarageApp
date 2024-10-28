using Common.DTOs.English;
using Data.Entities;

namespace Services
{
    public interface IUserService
    {
        ENUserDetailsDto GetUserByUserName(string userName);
        bool UserExistsById(int id);
        User ValidateUser(LoginReqDto loginData);
    }
}