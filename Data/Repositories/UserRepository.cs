using Data.Entities;
using Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class UserRepository
    {
        public UserRepository()
        {
            User user1 = new User()
            {
                Id = 1,
                Name = "Test",
                Password = "password",
                IsActive = true,
                UserName = "asdasd@gmail.com",
                Phone = "1234567890",
                State = States.DrinkingMate
            };
            Users.Add(user1);

            User user2 = new User()
            {
                Id = 2,
                Name = "Test2",
                Password = "password2",
                IsActive = false,
            };
            Users.Add(user2);
        }
        public List<User> Users { get; set; } = new List<User>();
        public bool ValidateUser(string username, string password)
        {
            return Users.Any(u => u.IsActive == true && u.UserName == username && u.Password == password);
            //además de checkear el username y el password me fijo que sea active

        }
    }
}
