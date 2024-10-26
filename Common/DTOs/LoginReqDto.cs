using System.ComponentModel.DataAnnotations;

namespace Common.DTOs
{
    public class LoginReqDto
    {
        public string UserName { get; set; } // = mail
        public string Password { get; set; }
    }
}
