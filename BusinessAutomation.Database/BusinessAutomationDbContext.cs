
using BusinessAutomation.Models.EntityModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BusinessAutomation.Database
{
    public class BusinessAutomationDbContext : DbContext
    {
        
        public BusinessAutomationDbContext(DbContextOptions options) : base(options)
        {
           
        }
        //public BusinessAutomationDbContext()
        //{
            
        //}
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Brand> Brands { get; set; }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{

        //    string connectionString = "Server=(local); Database=BusinessAutomationDB; Trusted_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets=true";
        //    optionsBuilder
        //        //.UseLazyLoadingProxies()
        //        .UseSqlServer(connectionString);


        //}
    }
}
