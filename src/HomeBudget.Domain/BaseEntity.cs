using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeBudget.Domain
{
    public abstract class BaseEntity
    {
        public DateTime CreationDate { get; set; }
        public bool IsDeleted { get; set; }

        protected BaseEntity()
        {
            CreationDate = DateTime.Now;
        }
    }

}
