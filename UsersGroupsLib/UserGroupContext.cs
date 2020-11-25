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
            modelBuilder.Entity<Test>().HasMany(x => x.QuestionBlocks).WithRequired(x => x.Test).WillCascadeOnDelete(true);
        }

        public UserGroupContext(string conStr) : base(conStr) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Test> Tests { get; set; }
        public DbSet<QuestionBlock> QuestionBlocks { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<ApointTest> ApointTests { get; set; }
    }
}
