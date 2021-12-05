using Microsoft.EntityFrameworkCore;
using ReviewApp.Core.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ReviewApp.Infra.Data.Sql.Common
{
   public class ReviewAppContext : DbContext
    {
        public ReviewAppContext(DbContextOptions<ReviewAppContext> options) : base(options)
        {
           
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Like> Likes { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Picture> Pictures { get; set; }
      
    }
}
