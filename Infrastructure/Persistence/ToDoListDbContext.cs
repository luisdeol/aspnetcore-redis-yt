using Microsoft.EntityFrameworkCore;
using RedisToDoList.API.Core.Entities;

namespace RedisToDoList.API.Infrastructure.Persistence
{
    public class ToDoListDbContext : DbContext
    {
        public ToDoListDbContext(DbContextOptions<ToDoListDbContext> options) : base(options) { }

        public DbSet<ToDo> ToDos { get; set; }

        protected override void OnModelCreating(ModelBuilder builder) {
            builder.Entity<ToDo>()
                .HasKey(t => t.Id);
        }
    }
}