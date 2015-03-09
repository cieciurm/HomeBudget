using System.Data.Entity;
using HomeBudget.Domain;
using HomeBudget.Mapping.Abstraction;

namespace HomeBudget.Mapping
{
    public class HomeBudgetContext : DbContext, IContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Budget> Budgets { get; set; }

        public HomeBudgetContext()
            : base("HomeBudgetConnection")
        {
        }

        public void Commit()
        {
            SaveChanges();
        }
    }
}
