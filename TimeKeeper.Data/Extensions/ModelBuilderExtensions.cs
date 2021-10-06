using TimeKeeper.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace TimeKeeper.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppConfig>().HasData(
               new AppConfig() { Key = "HomeTitle", Value = "This is home page of eShopTruongSport" },
               new AppConfig() { Key = "HomeKeyword", Value = "This is keyword of eShopTruongSport" },
               new AppConfig() { Key = "HomeDescription", Value = "This is description of eShopTruongSport" }
               );
           

            // any guid
            var roleId = new Guid("8D04DCE2-969A-435D-BBA4-DF3F325983DC");
            var adminId = new Guid("69BD714F-9576-45BA-B5B7-F00649BE00DE");
            modelBuilder.Entity<AppRole>().HasData(new AppRole
            {
                Id = roleId,
                Name = "admin",
                NormalizedName = "admin",
                Description = "Administrator role"
            });

            var hasher = new PasswordHasher<AppUser>();
            modelBuilder.Entity<AppUser>().HasData(new AppUser
            {
                Id = adminId,
                UserName = "admin",
                NormalizedUserName = "admin",
                Email = "truongcntt98@gmail.com",
                NormalizedEmail = "truongcntt98@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "truonghust98"),
                SecurityStamp = string.Empty,
                FirstName = "Truong",
                LastName = "Dinh",
                Dob = new DateTime(2020,01,31)
            });

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = roleId,
                UserId = adminId
            });
        }

        


    }
}
