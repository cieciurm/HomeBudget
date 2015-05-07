using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using HomeBudget.Contracts.Helpers;

namespace HomeBudget.Contracts.Grids
{
    public interface IGridViewModelBase<T>
    {
        IGridViewModelBase<T> AddColumn(Expression<Func<T, object>> field, string displayName);
        string GridHtmlId { get; }
        List<ColumnDefinition> ColumnDefs { get; set; }
        List<T> Data { get; set; }
        IGridViewModelBase<T> BuildGrid();
    }

    public abstract class GridViewModelBase<T> : IGridViewModelBase<T>
    {
        protected GridViewModelBase(string gridId)
        {
            GridHtmlId = gridId;
            ColumnDefs = new List<ColumnDefinition>();
            // ReSharper disable once DoNotCallOverridableMethodsInConstructor
            BuildGrid();
        }

        public abstract IGridViewModelBase<T> BuildGrid();

        public string GridHtmlId { get; private set; }
        public List<ColumnDefinition> ColumnDefs { get; set; }
        public List<T> Data { get; set; }

        public IGridViewModelBase<T> AddColumn(Expression<Func<T, object>> field, string displayName)
        {
            ColumnDefs.Add(new ColumnDefinition(PropertyHelper.GetFullPropertyName(field), displayName));
            return this;
        }
    }
}
