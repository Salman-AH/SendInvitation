using DemoUsersManagementCommandSide.Events;
using Microsoft.EntityFrameworkCore;

namespace DemoUsersManagementCommandSide.Infrastructuer.Persistence
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): DbContext(options)
    {
        public DbSet<Event> Events { get; set; }

    }
}
