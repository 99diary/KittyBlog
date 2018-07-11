using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using KittyBlog.Model;
using System.Linq;
using KittyBlog.Common;

namespace KittyBlog.DAL
{
    public class PostContext : DbContext
    {
        public PostContext(DbContextOptions<PostContext> options) : base(options)
        { }

        public DbSet<Post> Posts { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Post>().HasKey(m => m.ID);

            // shadow properties
            builder.Entity<Post>().Property<Int64>("PublishTimeStamp");

            base.OnModelCreating(builder);
        }

        public override int SaveChanges()
        {
            ChangeTracker.DetectChanges();

            updateUpdatedProperty<Post>();

            return base.SaveChanges();
        }

        private void updateUpdatedProperty<T>() where T : class
        {
            var modifiedSourceInfo =
                ChangeTracker.Entries<T>()
                    .Where(e => e.State == EntityState.Added || e.State == EntityState.Modified);
            foreach (var entry in modifiedSourceInfo)
            {
                entry.Property("UpdateTimeStamp").CurrentValue = TimeSpanService.GetCurrentTimeUnix();
            }
        }
    }
}
