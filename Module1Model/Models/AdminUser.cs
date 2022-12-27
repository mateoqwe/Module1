using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Module1Model.Models
{
    public class AdminUser
    {
        [Key]
        public int adminUserId { get; set; }

        [Required]
        public string userName { get; set; }

        [Required]
        public string password { get; set; }

        [ForeignKey("AdminUserRole")]
        public int adminUserRoleId { get; set; }

        public AdminUserRole adminUserRole { get; set; }
    }
}
