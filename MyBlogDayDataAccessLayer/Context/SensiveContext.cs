
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyBlogDayEntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogDayDataAccessLayer.Context
{
    public class SensiveContext : IdentityDbContext<AppUser, AppRole,int>

    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-58A8LDS\\SQLEXPRESS; Initial Catalog=SensiveBlogDb; integrated security=true; TrustServerCertificate=True; ");
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<NewsLetter> NewsLetters { get; set; }
        public DbSet<TagCloud> TagClouds { get; set; }
    }
}
