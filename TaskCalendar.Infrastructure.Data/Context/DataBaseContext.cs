using Microsoft.EntityFrameworkCore;
using TaskCalendar.Domain.Core;

namespace TaskCalendar.Infrastructure.Data.Context
{
    public class DataBaseContext : DbContext
    {
        public DbSet<Task> Tasks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=TaskStore;Trusted_Connection=True;Integrated Security=True;");
        }
    }
}
