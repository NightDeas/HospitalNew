using DataBase.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataBase
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }

        public Context()
        {
        }

        private readonly string _connectionString;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Data Source=169.254.131.3;Initial Catalog=Burnasov_wsr_hospital;User ID=Stud;Password=Qwerty123456$;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-3VRB7GU;Initial Catalog=Hospital;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

        public DbSet<Patient> Patients { get; set; }
        public DbSet<MedCard> MedCards { get; set; }
        public DbSet<InsurancePolicy> InsurancePolicies { get; set; }
        public DbSet<Genre> Genres { get; set; }

    }
}
