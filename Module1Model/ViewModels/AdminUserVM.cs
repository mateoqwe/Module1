using Module1Model.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Module1Model.ViewModels
{
    public class AdminUserVM
    {
        public AdminUser adminUser { get; set; }

        public IEnumerable<SelectListItem> adminUserRoleList { get; set; }
    }
}
