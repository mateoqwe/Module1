using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1Model.Models
{
    public class AdminUserFromView
    {
        public int adminUserId { get; set; }

        public string userName { get; set; }

        public int adminUserRoleId { get; set; }

        public string roleName { get; set; }
    }
}
