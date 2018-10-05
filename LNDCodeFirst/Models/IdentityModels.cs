using System.Data.Entity;
using System.Net.NetworkInformation;
using System.Security.Claims;
using System.Threading.Tasks;
using LNDCodeFirst.EntityConfigurations;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace LNDCodeFirst.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {

        public DbSet<Province> Provinces { get; set; }

        public DbSet<Person> Persons { get; set; }

        public DbSet<Semat> Semats { get; set; }

        public DbSet<Company> Companies { get; set; }

        public DbSet<FieldOfActivity> FieldOfActivities { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new PersonConfiguration());

            modelBuilder.Configurations.Add(new SematConfiguration());
            
            modelBuilder.Configurations.Add(new ProvinceConfiguration());
            
            modelBuilder.Configurations.Add(new CompanyConfiguration());

            modelBuilder.Configurations.Add(new FieldOfActivityConfiguration());
        }

        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}