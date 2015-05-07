using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeBudget.Contracts.Expenses;

namespace HomeBudget.Logic.Expenses
{
    public class ExpensesRootViewModelFactory
    {
        public static string ExpensesGridId = "ExpensesGridId";

        public static ExpensesRootViewModel Create()
        {
            var viewModel = new ExpensesRootViewModel();
            viewModel.ExpensesGridViewModel = new ExpensesGridViewModel(ExpensesGridId);
            return viewModel;
        }
    }
}
