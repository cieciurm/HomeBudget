using System;

namespace HomeBudget.Domain
{
    /// <summary>
    /// Base entity
    /// </summary>
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreationDate { get; set; }
        public bool IsDeleted { get; set; }

        public BaseEntity()
        {
            CreationDate = DateTime.Now;
        }
    }
}
