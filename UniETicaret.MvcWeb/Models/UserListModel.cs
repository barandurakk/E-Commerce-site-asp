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


namespace UniETicaret.MvcWeb.Models
{

   public class UserListModel
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
    }

    
    public class UserDetailModel
    {
        public IList<string> UserRoles { get; set; }
        public ApplicationUser User { get; set; }
        public List<ApplicationRole> Roles { get; set; }
    }

    public class UserUpdateModel
    {
        public string UserId { get; set; }
        public string RoleName { get; set; }
        public string RoleId { get; set; }
        public string[] RoleToAdd { get; set; }
        
    }

}