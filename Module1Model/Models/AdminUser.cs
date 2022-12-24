using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
