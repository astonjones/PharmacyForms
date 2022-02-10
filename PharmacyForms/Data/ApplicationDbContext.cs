using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PharmacyForms.Models;

namespace PharmacyForms.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<PatientCountModel> PatientCounts { get; set; }
        public virtual DbSet<EndOfDayModel> EndOfDay { get; set; }
     }
}