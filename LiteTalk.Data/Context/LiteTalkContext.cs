using LiteTalk.Data.Entities.Chats;
using LiteTalk.Data.Entities.Roles;
using LiteTalk.Data.Entities.Users;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiteTalk.Data.Context
{
    public class LiteTalkContext:DbContext
    {
        public LiteTalkContext(DbContextOptions<LiteTalkContext> options):base(options) { }

        #region Entities
        public DbSet<Chat> Chats { get; set; }
        public DbSet<ChatGroup> ChatGroups { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<RolePermission> RolePermissions { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Chat>()
                .HasOne(b=>b.User)
                .WithMany(b => b.Chats)
                .HasForeignKey(b => b.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(modelBuilder);
        }
    }
}
