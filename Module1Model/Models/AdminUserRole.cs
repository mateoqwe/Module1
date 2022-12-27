using System.ComponentModel.DataAnnotations;

namespace Module1Model.Models
{
    public class AdminUserRole
    {
        [Key]
        public int adminUserRoleId { get; set; }

        [Required]
        public string roleName { get; set; }

        public int? rolePower { get; set; }

        public List<AdminUser>? adminUsers { get; set; }
    }
}
