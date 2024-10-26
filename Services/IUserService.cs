using Common.DTOs.English;
using Data.Entities;

namespace Services
{
    public interface IUserService
    {
        ENUserDetailsDto GetUserByUserName(string userName);
        User ValidateUser(LoginReqDto loginData);
    }
}