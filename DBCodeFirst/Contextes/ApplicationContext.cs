using DBCodeFirst.Employees;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DBCodeFirst.Contextes
{
    internal class ApplicationContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder();
            // set the path to the current directory
            builder.SetBasePath(Directory.GetCurrentDirectory());
            // get configuration from appsettings.json file
            builder.AddJsonFile("appsettings.json");
            // create configuration
            var config = builder.Build();
            // get connection string
            var conString = config.GetConnectionString("DefaultConnection");
            optionsBuilder.UseSqlServer(conString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeProjects.EmployeeProjectConfiguration());
            modelBuilder.ApplyConfiguration(new Offices.OfficeConfiguration());
            modelBuilder.ApplyConfiguration(new Projects.ProjectConfiguration());
            modelBuilder.ApplyConfiguration(new Titles.TitleConfiguration());
            modelBuilder.Entity<EmployeeProjects.EmployeeProject>()
                .HasOne(e => e.Employee)
                .WithMany(p => p.Projects)
                .HasForeignKey(e => e.EmployeeId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<EmployeeProjects.EmployeeProject>()
                .HasOne(p => p.Project)
                .WithMany(ep => ep.EmployeeProjects)
                .HasForeignKey(f => f.ProjectId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Employee>()
                .HasOne(o => o.Office)
                .WithMany(e => e.Employees)
                .HasForeignKey(e => e.EmployeeId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Employee>()
                .HasOne(t => t.Title)
                .WithMany(e => e.Employees)
                .HasForeignKey(e => e.EmployeeId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
