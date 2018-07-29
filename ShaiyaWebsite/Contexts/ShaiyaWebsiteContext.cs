using ShaiyaWebsite.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;

namespace ShaiyaWebsite.Contexts
{
    public class ShaiyaWebsiteContext : DbContext
    {
        public ShaiyaWebsiteContext()
            : base("name=ShaiyaWebsiteContext")
        {
        }

        public DbSet<User> Users { get; set; }

        public override int SaveChanges()
        {
            var result = base.SaveChanges();

            if (result > 0)
            {
                // Dont forget to save user from website to game db.
                var addedUsers = ChangeTracker.Entries()
                                    .Where(dbEntry => dbEntry.Entity is User)
                                    .Select(dbEntry => dbEntry.Entity as User);
                SaveUsersToGameDb(addedUsers);
            }
            

            return result;
        }

        private void SaveUsersToGameDb(IEnumerable<User> addedUsers)
        {
            foreach (var userWebsite in addedUsers)
            {
                using (var shaiyaDb = new ShaiyaContext())
                {
                    var userGame = new Users_Master();
                    userGame.UserUID = userWebsite.Id;
                    userGame.UserID = userWebsite.Login;
                    userGame.Pw = userWebsite.Password;
                    userGame.JoinDate = userWebsite.RegistrationDate;
                    userGame.UserType = "";

                    shaiyaDb.Users_Master.Add(userGame);
                    shaiyaDb.SaveChanges();
                }
            }
        }
    }
}