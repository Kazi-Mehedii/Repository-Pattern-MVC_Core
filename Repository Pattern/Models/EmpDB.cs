using Microsoft.EntityFrameworkCore;

namespace Repository_Pattern.Models
{
    public class EmpDB:DbContext
    {
       public EmpDB(DbContextOptions<EmpDB> options) : base(options) { }

        public DbSet<Employee> Employees { get; set;}

    }

   
}
