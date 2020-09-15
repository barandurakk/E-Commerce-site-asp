using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UniETicaret.MvcWeb.Entity;
using UniETicaret.MvcWeb.Identity;
using UniETicaret.MvcWeb.Models;


namespace UniETicaret.MvcWeb.Controllers
{
    [Authorize(Roles = "admin")]
    public class UserController : Controller
    {
        private UserManager<ApplicationUser> userManager;
        private RoleManager<ApplicationRole> roleManager;

        public UserController() // contructor
        {

            var userContext = new IdentityDataContext();
            var userStore = new UserStore<ApplicationUser>(userContext);
            userManager = new UserManager<ApplicationUser>(userStore);

            var roleContext = new IdentityDataContext();
            var roleStore = new RoleStore<ApplicationRole>(roleContext);
            roleManager = new RoleManager<ApplicationRole>(roleStore);


        }


        // GET: User
        public ActionResult Index()
        {

            IdentityDataContext db = new IdentityDataContext();


            var userroles = (from user in db.Users
                             select new
                             {
                                 UserId = user.Id,
                                 Username = user.UserName,
                                 Email = user.Email,
                                 RoleNames = (from userRole in user.Roles
                                              join role in db.Roles on userRole.RoleId
                                              equals role.Id
                                              select role.Name).ToList()
                             }).ToList().Select(p => new UserListModel
                             {
                                 UserId = p.UserId,
                                 UserName = p.Username,
                                 Email = p.Email,
                                 Role = string.Join(" | ", p.RoleNames)
                             });
         


            return View(userroles);
        }


        public ActionResult Delete(string id)
        {
            

            var user = userManager.FindById(id);
            userManager.Delete(user);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UserRoleEdit(string id)
        {

            var userroles = userManager.GetRoles(id);
            var user = userManager.FindById(id);
            var roles = roleManager.Roles.ToList();

            var model = new UserDetailModel()
            {
                UserRoles = userroles.ToList(),
                User = user,
                Roles = roles
                
            };


            return View(model);
        }

        [HttpPost]
        public ActionResult UserRoleEdit(UserUpdateModel model)
        {
            if (ModelState.IsValid)
            {
                foreach (var role in model.RoleToAdd)
                {
                    userManager.AddToRole(model.UserId, role);
                }
            }


            return View(model);
        }
    }
}