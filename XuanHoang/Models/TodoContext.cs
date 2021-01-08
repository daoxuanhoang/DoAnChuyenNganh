using Microsoft.EntityFrameworkCore;

namespace XuanHoang.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options)
            : base(options)
        {
        }

        public DbSet<TodoItem> TodoItem { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Customers> Customers{get;set;}
        public DbSet<Category> Category{get;set;}
        public DbSet<Orders> Orders{get;set;}
    }
}