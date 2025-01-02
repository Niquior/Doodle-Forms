using Microsoft.EntityFrameworkCore;

namespace Doodle_Forms.Migrations
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Template> Templates { get; set; }
        public DbSet<Form> Forms { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>().HasKey(user => user.Id);
            modelBuilder.Entity<Template>().HasKey(template => template.Id);
            modelBuilder.Entity<Form>().HasKey(form => form.Id);
        }
    }
}
