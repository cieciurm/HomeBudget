using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeBudget.Contracts;
using HomeBudget.Contracts.Grids;

namespace HomeBudget.Logic
{
    public interface IGridBuilder<TGridItemViewModel>
        where TGridItemViewModel : IBaseGridItemViewModel
    {
        IGridViewModelBase<TGridItemViewModel> BuildGrid();
    }
}
