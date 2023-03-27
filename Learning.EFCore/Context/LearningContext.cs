using Learning.Domain.AboutUs;
using Learning.Domain.Degrees;
using Learning.Domain.Groups;
using Learning.Domain.Links;
using Learning.Domain.Scopes;
using Learning.Domain.Users;
using Learning.Infrastructure.EFCore.Mappings.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.Infrastructure.EFCore.Context
{
    public class LearningContext:DbContext
    {
        public LearningContext(DbContextOptions<LearningContext> options):base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserInRole> UserInRoles { get; set; }
        public DbSet<Scope> Scopes { get; set; }
        public DbSet<UserInScope> UserInScopes { get; set; }
        public DbSet<Link> Links { get; set; }
        public DbSet<AboutUs> AboutUs { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<UserInGroup> UserInGroups { get; set; }
        public DbSet<Degree> Degrees { get; set; }
        public DbSet<UserInDegree> UserInDegrees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("lrn");
            modelBuilder.Entity<User>().HasQueryFilter(u => !u.IsRemoved);
            modelBuilder.Entity<Role>().HasQueryFilter(u => !u.IsRemoved);
            modelBuilder.Entity<User>().HasIndex(u => u.UserName).IsUnique();

            modelBuilder.ApplyConfiguration(new UserMapping());
            modelBuilder.ApplyConfiguration(new RoleMapping());
            modelBuilder.ApplyConfiguration(new UserInRoleMapping());
        }
    }
}
