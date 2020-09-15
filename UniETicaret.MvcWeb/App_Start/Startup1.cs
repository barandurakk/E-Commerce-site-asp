using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

[assembly: OwinStartup(typeof(UniETicaret.MvcWeb.App_Start.Startup1))]

namespace UniETicaret.MvcWeb.App_Start
{
    public class Startup1
    {
        public void Configuration(IAppBuilder app)
        {
            

            app.UseCookieAuthentication(new CookieAuthenticationOptions()  //Siteye cookie bırakıp kullanıcının hatırlanmasını sağlıyoruz.
            {
                AuthenticationType = "ApplicationCookie",
                LoginPath = new PathString("/Account/Login")  //Giriş yapma yolu tanımlıyoruz.
            });
        }
    }
}