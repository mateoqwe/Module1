using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Module1DataAccess.Data;
using Module1Model.Models;
using Module1Model.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace Module1.Controllers
{
    public class AdminUserController : Controller
    {
        private readonly ApplicationDbContext _db;

        public AdminUserController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            List<AdminUserFromView> objList = _db.AdminUserFromViews.ToList();
            return View(objList);
        }

        public IActionResult Upsert(int? id)
        {
            AdminUserVM obj = new AdminUserVM();
            obj.adminUserRoleList = _db.AdminUserRoles.Select(i => new SelectListItem
            {
                Text = i.roleName,
                Value = i.adminUserRoleId.ToString()
            });

            //Create New
            if (id == null)
            {
                return View(obj);
            }

            //Edit
            obj.adminUser = _db.AdminUsers.FirstOrDefault(u => u.adminUserId == id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(AdminUserVM obj)
        {
            if (obj.adminUser.adminUserId == 0)
            {
                //Create New
                _db.AdminUsers.Add(obj.adminUser);
            }
            else
            {
                //Edit
                _db.AdminUsers.Update(obj.adminUser);
            }
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
