using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UniETicaret.MvcWeb.Identity;
using UniETicaret.MvcWeb.Models;

namespace UniETicaret.MvcWeb.Controllers
{
    
    public class RoleController : Controller
    {

        private RoleManager<IdentityRole> roleManager;
        private UserManager<ApplicationUser> userManager;

        public RoleController()
        {
            var roleContext = new IdentityDataContext();
            var roleStore = new RoleStore<IdentityRole>(roleContext);
            roleManager = new RoleManager<IdentityRole>(roleStore);

            var userContext = new IdentityDataContext();
            var userStore = new UserStore<ApplicationUser>(userContext);
            userManager = new UserManager<ApplicationUser>(userStore);

        }

        public ActionResult Index()
        {
            return View(roleManager.Roles);
        }


        [HttpGet]
        public ActionResult Create()
        {

            return View();
        }


        [HttpPost]
        public ActionResult Create(string name)
        {
            if (ModelState.IsValid)
            {
                var result = roleManager.Create(new IdentityRole(name));

                if (result.Succeeded)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error);
                    }
                }
            }
            return View(name);
        }

        [HttpPost]
        public ActionResult Delete(string id)
        {
            var role = roleManager.FindById(id);
            if (role == null)
            {
                return View("Error", new string[] { "Rol Bulunamadı" });
            }
            else
            {


                var result = roleManager.Delete(role);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return View("Error", result.Errors);
                }
            }
        }

        [HttpGet]
        public ActionResult Edit(string id)
        {
            var rol = roleManager.FindById(id);

            var members = new List<ApplicationUser>();
            var nonmembers = new List<ApplicationUser>();

            foreach (var user in userManager.Users.ToList())
            {
                var list = userManager.IsInRole(user.Id, rol.Name) ? members : nonmembers;

                list.Add(user);
            }

            return View(new RoleEditModel
            {
                Role = rol,
                Members = members,
                nonMembers = nonmembers
            });
        }

        [HttpPost]
        public ActionResult Edit(RoleUpdateModel model)
        {

            if (ModelState.IsValid)
            {
                foreach (var userid in model.IdsToAdd ?? new string[] { })
                {
                    userManager.AddToRole(userid, model.RoleName);

                }
                foreach (var userid in model.IdsToDelete ?? new string[] { })
                {
                    userManager.RemoveFromRole(userid, model.RoleName);

                }
                return RedirectToAction("Index");
            }

            return View("Error", new string[] { "Aranılan Rol Bulunamadı" });
        }


    }
}