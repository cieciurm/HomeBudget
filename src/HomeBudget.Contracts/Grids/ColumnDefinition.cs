using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeBudget.Contracts.Grids
{
    public class ColumnDefinition
    {
        public ColumnDefinition(string field, string displayName)
        {
            Field = field;
            DisplayName = displayName;
        }

        public string Field { get; set; }
        public string DisplayName { get; set; }
    }
}
