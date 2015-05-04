using System;

namespace HomeBudget.Domain
{
    public interface IModelWithId
    {
        int Id { get; set; }
    }

    public abstract class BaseEntityWithId : BaseEntity, IModelWithId
    {
        public int Id { get; set; }
    }
}
