using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeBudget.Domain
{
    public class Account : BaseEntityWithId
    {
        public string Name { get; set; }
        public double ActualAmount { get; set; }
        public double InitialAmount { get; set; }
        public AccountType Type { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
