using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using HomeBudget.Domain;

namespace HomeBudget.Contracts.Expenses
{
    public class ExpenseViewModel : BaseViewModel
    {
        public double Amount { get; set; }
        public DateTime ExpenseDate { get; set; }
        public string Comment { get; set; }
        public NameIdViewModel Account { get; set; }
        public NameIdViewModel Category { get; set; }
    }
}
