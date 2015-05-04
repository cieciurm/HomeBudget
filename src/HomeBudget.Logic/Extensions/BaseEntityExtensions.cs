using System.Linq;
using HomeBudget.Domain;

namespace HomeBudget.Logic.Extensions
{
    public static class BaseEntityExtensions
    {
        public static IQueryable<T> GetNotDeleted<T>(this IQueryable<T> entities) where T : BaseEntityWithId
        {
            return entities.Where(x => x.IsDeleted == false);
        }
    }
}
