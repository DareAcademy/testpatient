using Microsoft.EntityFrameworkCore;

namespace testPatient.data
{
    public class ClinicContext:DbContext
    {
        public DbSet<Patient> patients { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=localhost;database=patientTest;integrated security=true;trustservercertificate=true");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
