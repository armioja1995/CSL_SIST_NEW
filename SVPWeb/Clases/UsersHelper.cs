using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
//using SVPRepository;
//using SVPDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Configuration;
using SVPWeb.Models;

namespace SVPWeb.Clases
{
    public class UsersHelper : IDisposable
    {
        //integra ambas bases de datos pero en diferentes contextos para el logueo existente en asp
        private static ApplicationDbContext _userContext = new ApplicationDbContext();
        //private static SVPContext _db = new SVPContext();


        public static bool DeleteUser(string userName)
        {
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(_userContext));
            var userASP = userManager.FindByEmail(userName);
            if (userASP == null)
            {
                return false;
            }
            var response = userManager.Delete(userASP);
            //devuelve verdadero o falso la borrada del usuario
            return response.Succeeded;
        }

        public static bool UpdateUserName(string emailActual, string nuevoEmail)
        {
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(_userContext));
            var userAsp = userManager.FindByEmail(emailActual);
            if (userAsp == null)
            {
                return false;
            }
            userAsp.UserName = nuevoEmail;
            userAsp.Email = nuevoEmail;
            var response = userManager.Update(userAsp);
            return response.Succeeded;
        }


        //pasa como parametro el rol; si no existe lo crea
        public static void CheckRole(string roleName)
        {
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(_userContext));

            //Check to see if Role Exists, if not create it
            if (!roleManager.RoleExists(roleName))
            {
                roleManager.Create(new IdentityRole(roleName));
            }

        }

        public static void CheckSuperUser()
        {
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(_userContext));
            var email = WebConfigurationManager.AppSettings["AdminUser"];
            var password = WebConfigurationManager.AppSettings["AdminPassWord"];
            var userAsp = userManager.FindByName(email);
            if (userAsp == null)
            {
                CreateUserASP(email, "Admin", password);
                return;
            }

            userManager.AddToRole(userAsp.Id, "Admin");
        }
        public static void CreateUserASP(string email, string roleName)
        {
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(_userContext));

            var userASP = new ApplicationUser
            {
                Email = email,
                UserName = email,
            };

            userManager.Create(userASP, email);
            userManager.AddToRole(userASP.Id, roleName);
        }

        public static void CreateUserASP(string email, string roleName, string password)
        {
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(_userContext));

            var userASP = new ApplicationUser
            {
                Email = email,
                UserName = email,
            };

            userManager.Create(userASP, password);
            userManager.AddToRole(userASP.Id, roleName);
        }

        public static async Task PasswordRecovery(string email)
        {
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(_userContext));
            var userASP = userManager.FindByEmail(email);
            if (userASP == null)
            {
                return;
            }

            //var user = _db.Trabajadores.FirstOrDefault(tp => tp.Email == email);
            //if (user == null)
            //{
                return;
            //}

            //var random = new Random();
            //var newPassword = string.Format("{0}{1}{2:04}*",
            //    user.Nombres.Trim().ToUpper().Substring(0, 1),
            //    user.ApePat.Trim().ToLower(),
            //    random.Next(10000));


            //userManager.RemovePassword(userASP.Id);
            //userManager.AddPassword(userASP.Id, newPassword);

            //var subject = "Taxes Password Recovery";
            //var body = string.Format(@"
            //    <h1>Taxes Password Recovery</h1>
            //    <p>Yor new password is: <strong>{0}</strong></p>
            //    <p>Please change it for one, that you remember easyly",
            //    newPassword);

            //await MailHelper.SendMail(email, subject, body);
        }

        public void Dispose()
        {
            _userContext.Dispose();
            //_db.Dispose();
        }
    }
}