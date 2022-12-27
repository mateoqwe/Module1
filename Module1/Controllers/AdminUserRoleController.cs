using Microsoft.AspNetCore.Mvc;
using Module1DataAccess.Data;
using Module1Model.Models;
using Microsoft.EntityFrameworkCore;

namespace Module1.Controllers
{
    public class AdminUserRoleController : Controller
    {
        private readonly ApplicationDbContext _db;

        public AdminUserRoleController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            List<AdminUserRole> objList = _db.AdminUserRoles.AsNoTracking().ToList();
            return View(objList);
        }

        public IActionResult Upsert(int? id)
        {
            AdminUserRole obj = new AdminUserRole();
            //Create New
            if (id == null)
            {
                return View(obj);
            }

            //Edit
            obj = _db.AdminUserRoles.FirstOrDefault(u => u.adminUserRoleId == id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(AdminUserRole obj)
        {
            if (ModelState.IsValid)
            {
                if (obj.adminUserRoleId == 0)
                {
                    //Create New
                    _db.AdminUserRoles.Add(obj);
                }
                else
                {
                    //Edit
                    _db.AdminUserRoles.Update(obj);
                }
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(obj);

        }

        public IActionResult Delete(int id)
        {
            var objFromDb = _db.AdminUserRoles.FirstOrDefault(u => u.adminUserRoleId == id);
            _db.AdminUserRoles.Remove(objFromDb);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
