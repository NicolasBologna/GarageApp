using Common.DTOs;
using Data.Entities;
using Data.Repositories;

namespace Services
{
    public class UserService
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
    }
}
