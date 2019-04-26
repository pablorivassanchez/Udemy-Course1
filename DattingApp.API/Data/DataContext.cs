using DattingApp.API.Model;
using Microsoft.EntityFrameworkCore;

namespace DattingApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options) { }
        public DbSet<Value> Values { get; set; }
        public DbSet<User> Users { get; set; }
    }
}