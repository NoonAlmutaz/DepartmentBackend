using Microsoft.EntityFrameworkCore;

namespace WebApplication6.Models.Data
{
    public class AppDB : DbContext
    {
   
        public AppDB(DbContextOptions options) : base(options)
        {

        }

        public DbSet <Employee> Employee { get; set; }

        public DbSet<Department> Department { get; set; }

        public DbSet<EmployeeStatus> EmployeeStatus { get; set; }
        public DbSet<JobTitle> JobTitle { get; set; }



        protected AppDB()
        {
        }
    }
}
