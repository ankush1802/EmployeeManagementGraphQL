using EmployeeManagementGraphQL.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagementGraphQL.Data
{
    public class EntityDatabaseContext : DbContext
    {
        public EntityDatabaseContext(DbContextOptions<EntityDatabaseContext> options) : base(options)
        {
        }
        public DbSet<Employee> EmployeeEntity {  get; set; }
        public DbSet<Review> ReviewEntity { get; set; }
    }
}
