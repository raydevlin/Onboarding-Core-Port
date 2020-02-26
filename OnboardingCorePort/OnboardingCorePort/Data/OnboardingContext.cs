using Microsoft.EntityFrameworkCore;
using OnboardingCorePort.Models;
using Microsoft.Extensions.Configuration;
using System.Linq;
using System.Collections.Generic;

namespace OnboardingCorePort.Data
{
    public class OnboardingContext : DbContext
    {

        private IConfiguration _configuration;

        public OnboardingContext()
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(_configuration.GetConnectionString("onboardingDb"));
            optionsBuilder.UseSqlServer(@"Server=LT-785;Database=onboardingDb;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Component> Components { get; set; }
        public DbSet<Layout> Layouts { get; set; }
        public DbSet<Log> Logs { get; set; }
        public DbSet<LevelSatisfied> LevelsSatisfied { get; set; }
        public DbSet<Page> Pages { get; set; }
        public DbSet<UserFeedback> UserFeedbacks { get; set; }
        public DbSet<User> Users { get; set; }

        public Category GetCategory(int id)
        {
            return Categories.FirstOrDefault(c => c.CategoryID == id);
        }

        public List<Category> GetCategories()
        {
            return Categories.ToList();
        }

        public Component GetComponents(int id)
        {
            return Components
                        .Include(c => c.Layout)
                        .FirstOrDefault(c => c.ComponentID == id);
        }

        public Layout GetLayout(int id)
        {
            return Layouts
                        .Include(l => l.Components)
                        .FirstOrDefault(l => l.LayoutID == id);
        }

        public LevelSatisfied GetLevelSatisfied(int id)
        {
            return LevelsSatisfied.FirstOrDefault(l => l.LevelSatisfiedID == id);
        }

        public List<LevelSatisfied> GetLevelsSatisfied()
        {
            return LevelsSatisfied.ToList();
        }

        public Page GetPage(int id)
        {
            return Pages
                        .Include(p => p.Layout)
                        .Include(p => p.Layout.Components)
                        .FirstOrDefault(p => p.PageID == id);
        }

        public UserFeedback GetUserFeedBack(int id)
        {
            return UserFeedbacks
                        .Include(u => u.User)
                        .Include(u => u.LevelSatisfied)
                        .Include(u => u.Category)
                        .FirstOrDefault(u => u.UserFeedbackID == id);
        }

    }
}
