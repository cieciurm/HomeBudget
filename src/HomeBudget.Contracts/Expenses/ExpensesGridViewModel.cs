using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeBudget.Contracts.Grids;

namespace HomeBudget.Contracts.Expenses
{
    public class ExpensesGridViewModel : GridViewModelBase<ExpenseViewModel>
    {

        public ExpensesGridViewModel(string gridId)
            : base(gridId)
        {
        }

        public override IGridViewModelBase<ExpenseViewModel> BuildGrid()
        {
            return AddColumn(e => e.Category.Name, "Category")
                .AddColumn(e => e.Amount, "Expense")
                .AddColumn(e => e.ExpenseDate, "Date")
                .AddColumn(e => e.Account.Name, "Account")
                .AddColumn(e => e.Comment, "Comment");
        }


    }
}
