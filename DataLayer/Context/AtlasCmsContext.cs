using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using BasicModels;
namespace DataLayer.Context
{
    public class AtlasCmsContext : DbContext
    {
        static AtlasCmsContext()
        {
            Database.SetInitializer<AtlasCmsContext>(
                new DropCreateDatabaseIfModelChanges<AtlasCmsContext>());
            //Database.SetInitializer<AtlasCmsContext>(
            //    new CreateDatabaseIfNotExists<AtlasCmsContext>());
        }
        public AtlasCmsContext()
        {
        }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserType> UserTypes { get; set; }
        public DbSet<Attachment> Attachments { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<User>()
             .HasRequired(U => U.UserType)
             .WithMany()
             .Map(m => m.MapKey("Fk_UserType_Id"));
        }
    }
}
