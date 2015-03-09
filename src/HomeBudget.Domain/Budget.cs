namespace HomeBudget.Domain
{
    public class Budget : BaseEntity
    {
        public User User { get; set; }
        public int UserId { get; set; }
        public double Value { get; set; }
    }
}
