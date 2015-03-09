using System.Data.Entity;

namespace HomeBudget.Mapping.Abstraction
{
    public interface IContext : IUnitOfWork
    {
        DbSet<T> Set<T>() where T : class;
    }
}
