using MedicalConsultancyProject.Models;

public class AppContext : DbContext
{
    public AppContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<About> Abouts { get; set; }
    public DbSet<Appointment> Appointments { get; set; }
    public DbSet<Contact> Contacts { get; set; }
    public DbSet<Features> Features { get; set; }
    public DbSet<Services> Services { get; set; }
    public DbSet<Testimonials> Testimonials { get; set; }

<<<<<<< HEAD

    public DbSet<DoctorModel> Doctors { get; set; }
    public DbSet<PatientModel> Patients { get; set; }
=======
    // Add more DbSet properties if you have additional model classes

    // Override the OnModelCreating method if you need to configure the model further
>>>>>>> db00b521107a99e2191e89b135e26b2df419ee94
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Add any additional configurations here

        base.OnModelCreating(modelBuilder);
    }
}

<<<<<<< HEAD
=======
public class AppDbContext
{
}

>>>>>>> db00b521107a99e2191e89b135e26b2df419ee94
public class DbSet<T>
{
}

public class DbContext
{
}