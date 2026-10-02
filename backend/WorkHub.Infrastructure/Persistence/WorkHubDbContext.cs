using Microsoft.EntityFrameworkCore;
using WorkHub.Domain.Entities;

namespace WorkHub.Infrastructure.Persistence
{
    public class WorkHubDbContext : DbContext
    {
        public WorkHubDbContext(DbContextOptions<WorkHubDbContext> options) : base(options) { }

        public DbSet<User> User { get; set; } 
    }
}
