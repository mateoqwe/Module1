using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1Model.Models
{
    public class AdminUserRole
    {
        [Key]
        public int adminUserRoleId { get; set; }

        [Required]
        public string roleName { get; set; }
    }
}
