using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wmcb.model;
namespace wmcb.repo
{
    public class wmcbContext : DbContext
    {
        public DbSet<NewsFeed> NewsFeeds { get; set; }
        public DbSet<User> Users { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NewsFeed>().ToTable("NewsFeed");
            modelBuilder.Entity<User>().ToTable("Users");
        }
    }
}
