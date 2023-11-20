
using ScoreManagementApp.Models;
using System.Data.Entity;


namespace ScoreManagementApp.DAL
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("DefaultConnection") { }

        public DbSet<Score> Scores { get; set; }
    }
}