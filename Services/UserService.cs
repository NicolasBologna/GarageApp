using Common.DTOs;
using Data.Repositories;

namespace Services
{
    public class UserService
    {
        private readonly UserRepository _userRepository;

        public UserService(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public bool ValidateUser(LoginDto loginData)
        {
            return _userRepository.ValidateUser(loginData.UserName, loginData.Password);
        }
    }
}
