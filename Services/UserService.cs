using Common.DTOs.English;
using Data.Entities;
using Data.Repositories.Interfaces;

namespace Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public User ValidateUser(LoginReqDto loginData)
        {
            return _userRepository.ValidateUser(loginData.UserName, loginData.Password);
        }

        public ENUserDetailsDto GetUserByUserName(string userName)
        {
            User? dbUser = _userRepository.GetUserByUserName(userName);

            if (dbUser is null)
            {
                throw new Exception("User not found");
            }

            ENUserDetailsDto userDetails = new ENUserDetailsDto();
            userDetails.UserName = dbUser.UserName;
            userDetails.Name = dbUser.Name;
            userDetails.Phone = dbUser.Phone;
            userDetails.Role = dbUser.Role;
            userDetails.State = dbUser.State;
            userDetails.IsActive = dbUser.IsActive;
            userDetails.IsAdmin = dbUser.Role == Common.Enums.UserRoles.Admin;

            return userDetails;
        }

        public bool UserExistsById(int id)
        {
            User? dbUser = _userRepository.GetUserByUserId(id);

            return dbUser is not null;
        }
    }
}
