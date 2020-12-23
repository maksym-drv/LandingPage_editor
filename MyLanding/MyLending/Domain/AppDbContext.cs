using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyLending.Domain.Entities
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Information> Information { get; set; }
        public DbSet<Meta> Meta { get; set; }
        public DbSet<Skills> Skills { get; set; }
        public DbSet<Education> Education { get; set; }
        public DbSet<Experience> Experience { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "B17E239B-DD0D-452F-B0F2-1330A4FC16F0",
                Name = "admin",
                NormalizedName = "ADMIN"
            });
            builder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "AC0AE115-9B4C-449E-8921-80DD9ABBDAD3",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "maximadda2001@gmail.com",
                NormalizedEmail = "MAXIMADDA2001@GMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "mypassword"),
                SecurityStamp = string.Empty
            });
            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "B17E239B-DD0D-452F-B0F2-1330A4FC16F0",
                UserId = "AC0AE115-9B4C-449E-8921-80DD9ABBDAD3"
            });
            builder.Entity<Information>().HasData(new Information
            {
                Id = new Guid("B15737DF-7CE0-46E6-9197-17F6B0F9CAB2"),
                CodeWord = "PageAboutMe"
            });
            builder.Entity<Information>().HasData(new Information
            {
                Id = new Guid("D58771DE-3C15-47E9-B4BE-B3CC7168BEDB"),
                CodeWord = "PageSkills"
            });
            builder.Entity<Information>().HasData(new Information
            {
                Id = new Guid("38484FD3-0AF9-4313-94D4-E12118FC28BD"),
                CodeWord = "PageExperience"
            });
            builder.Entity<Information>().HasData(new Information
            {
                Id = new Guid("B7C91700-AE33-4D27-A65F-0FBEBD6DE04D"),
                CodeWord = "PageEducation"
            });
            builder.Entity<Meta>().HasData(new Meta
            {
                Id = new Guid("9BF2A434-E6F9-4E8C-A096-085CE2369D0B")
            });
        }
    }
}
