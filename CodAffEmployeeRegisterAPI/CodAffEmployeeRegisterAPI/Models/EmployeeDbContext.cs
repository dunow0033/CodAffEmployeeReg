using Microsoft.EntityFrameworkCore;

namespace CodAffEmployeeRegisterAPI.Models
{
    public class EmployeeDbContext:DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options) 
        {

        }

        public DbSet<EmployeeModel> Employees { get; set; }
    }
}
