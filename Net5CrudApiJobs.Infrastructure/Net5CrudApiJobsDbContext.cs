using Microsoft.EntityFrameworkCore;
using Net5CrudApiJobs.Infrastructure.Entities;

namespace Net5CrudApiJobs.Infrastructure
{
    public class Net5CrudApiJobsDbContext : DbContext
    {
        public DbSet <Job>  Jobs { get; set; }
        public DbSet <Person> Persons { get; set; }

        public Net5CrudApiJobsDbContext(DbContextOptions options) : base(options)
        {
        }

        public Net5CrudApiJobsDbContext()
        {

        }

    }
}
