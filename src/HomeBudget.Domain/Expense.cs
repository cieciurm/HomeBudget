using System;
using System.Collections.Generic;

namespace HomeBudget.Domain
{
    public class Expense : BaseEntity
    {
        public User User { get; set; }
        public int UserId { get; set; }

        public Category Category { get; set; }
        public int CategoryId { get; set; }

        public double Value { get; set; }
        public IList<Tag> Tags { get; set; }
        public DateTime ExpenseDate { get; set; }

        public Expense()
        {
            Tags = new List<Tag>();
        }
    }
}