using MedicalConsultancyProject.Models;

public class AppContext : DbContext
{
    public AppContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    // Define your DbSet properties for each model class
    public DbSet<About> Abouts { get; set; }
    public DbSet<Appointment> Appointments { get; set; }
    public DbSet<Contact> Contacts { get; set; }
    public DbSet<Features> Features { get; set; }
    public DbSet<Services> Services { get; set; }
    public DbSet<Testimonials> Testimonials { get; set; }

    // Add more DbSet properties if you have additional model classes

    // Override the OnModelCreating method if you need to configure the model further
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Add any additional configurations here

        base.OnModelCreating(modelBuilder);
    }
}

public class AppDbContext
{
}

public class DbSet<T>
{
}

public class DbContext
{
}