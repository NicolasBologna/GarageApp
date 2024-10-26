using Common.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entities
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        [Required]
        public string UserName { get; set; } // Es el mail
        [Required]
        public string Password { get; set; }
        public string Phone { get; set; }
        public UserStates State { get; set; }
        public bool IsActive { get; set; }
        public UserRoles Role { get; set; } = UserRoles.User;
    }
}
