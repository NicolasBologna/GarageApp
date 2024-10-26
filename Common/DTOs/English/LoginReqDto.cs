using System.ComponentModel.DataAnnotations;

namespace Common.DTOs.English
{
    public class LoginReqDto
    {
        public string UserName { get; set; } // = mail
        public string Password { get; set; }
    }
}
