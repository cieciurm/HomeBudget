using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using HomeBudget.Contracts.Helpers;

namespace HomeBudget.Contracts.Grids
{
    public class GridViewModelBase<T>
    {
        public GridViewModelBase(string gridId)
        {
            GridHtmlId = gridId;
            ColumnDefs = new List<ColumnDefinition>();
        }

        public string GridHtmlId { get; private set; }
        public List<ColumnDefinition> ColumnDefs { get; set; }
        public List<T> Data { get; set; }

        public GridViewModelBase<T> AddColumn(Expression<Func<T, object>> field, string displayName)
        {
            ColumnDefs.Add(new ColumnDefinition(PropertyHelper.GetFullPropertyName(field), displayName));
            return this;
        }
    }
}
