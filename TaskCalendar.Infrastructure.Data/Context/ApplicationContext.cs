using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using TaskCalendare.Domain.Core;

namespace TaskCalendar.Infrastructure.Data.Context
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Task> Tasks => Set<Task>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=taskCalendare.db");
        }
    }
}
