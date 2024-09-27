using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using DataAccess_Layer_Database.Entities;

public class ApplicationDbContext : IdentityDbContext<User, Role, int>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    // DbSets for all entities
    public DbSet<User> Users { get; set; }
    public DbSet<Role> roles { get; set; }
    //public DbSet<Payment> Payments { get; set; }
    //public DbSet<Courses> Courses { get; set; }
    //public DbSet<Review> Reviews { get; set; }
    //public DbSet<WishList> WishLists { get; set; }
    //public DbSet<Adminstrator> Administrators { get; set; }
    //public DbSet<Certificates> Certificates { get; set; }
    //public DbSet<Enrollments> Enrollments { get; set; }
    //public DbSet<QuizesAssignments> QuizAssignments { get; set; }
    //public DbSet<Category> Categories { get; set; }
    //public DbSet<Account> Accounts { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //Apply entity configurations
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);

       // Identity configurations
        base.OnModelCreating(modelBuilder);

       //Additional relationships or constraints can be defined here
    }
}
