using Common.DTOs;
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
        public bool ValidateUser(LoginDto loginData)
        {
            return _userRepository.ValidateUser(loginData.UserName, loginData.Password);
        }
    }
}
