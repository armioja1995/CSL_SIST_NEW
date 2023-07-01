namespace SVPWeb.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SVPWeb.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SVPWeb.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            var userStore = new UserStore<ApplicationUser>(context); //almacen de ususarios
            var userManager = new UserManager<ApplicationUser>(userStore);//getor de Usuarios

            if (!context.Users.Any(u => u.UserName.Equals("admin@Svp.pe")))
            {
                var user = new ApplicationUser()
                {
                    UserName = "admin@Svp.pe",
                    Email = "admin@Svp.pe",

                };
                userManager.Create(user, "Admin123*");
                context.Roles.AddOrUpdate(r => r.Name, new IdentityRole() { Name = "Administrador" });
                context.SaveChanges();
                userManager.AddToRole(user.Id, "Administrador");
            }
            if (!context.Users.Any(u => u.UserName.Equals("alindor@gmail.com")))
            {
                var user = new ApplicationUser()
                {
                    UserName = "alindor@gmail.com",
                    Email = "alindor@gmail.com"
                };
                userManager.Create(user, "password");
                userManager.AddToRole(user.Id, "Administrador");
            }
            if (!context.Users.Any(u => u.UserName.Equals("percy@gmail.com")))
            {
                var user = new ApplicationUser()
                {
                    UserName = "percy@gmail.com",
                    Email = "percy@gmail.com"
                };
                userManager.Create(user, "password");
                userManager.AddToRole(user.Id, "Administrador");
            }
            if (!context.Users.Any(u => u.UserName.Equals("auxiliar@gmail.com")))
            {
                var user = new ApplicationUser()
                {
                    UserName = "auxiliar@gmail.com",
                    Email = "auxiliar@gmail.com"
                };
                userManager.Create(user, "password");

                context.Roles.AddOrUpdate(r => r.Name, new IdentityRole() { Name = "Auxiliar" });

                context.SaveChanges();

                userManager.AddToRole(user.Id, "Auxiliar");
            }
            if (!context.Users.Any(u => u.UserName.Equals("vigilante@gmail.com")))
            {
                var user = new ApplicationUser()
                {
                    UserName = "vigilante@gmail.com",
                    Email = "vigilante@gmail.com"
                };
                userManager.Create(user, "password");

                context.Roles.AddOrUpdate(r => r.Name, new IdentityRole() { Name = "Vigilante" });

                context.SaveChanges();

                userManager.AddToRole(user.Id, "Vigilante");
            }
        }
    }
}
