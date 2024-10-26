using Common.Enums;

namespace Common.DTOs.English
{
    public class ENUserDetailsDto
    {
        public string? Name { get; set; }
        public string? UserName { get; set; } // Es el mail
        public string? Phone { get; set; }
        public UserStates? State { get; set; }
        public bool? IsActive { get; set; }
        public UserRoles? Role { get; set; }
        public bool IsAdmin { get; set; }
    }
}
