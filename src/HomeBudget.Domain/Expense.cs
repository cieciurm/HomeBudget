using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace HomeBudget.Domain
{
    public class Expense : BaseEntityWithId
    {
        public double Amount { get; set; }
        public DateTime ExpenseDate { get; set; }
        public string Comment { get; set; }
        public IList<Tag> Tags { get; set; }

        public Category Category { get; set; }
        public int CategoryId { get; set; }

        public Account Account { get; set; }
        public int AccountId { get; set; }

        public Expense()
        {
            Tags = new List<Tag>();
        }
    }
}