using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xml2CSharp;

namespace UsersGroupsLib
{
    public class UserGroupContext : DbContext
    {
        public UserGroupContext() { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Group>().HasMany(x => x.Users).WithRequired(x => x.Group).WillCascadeOnDelete(false);
        }

        public UserGroupContext(string conStr) : base(conStr) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Group> Groups { get; set; }
    }
}
