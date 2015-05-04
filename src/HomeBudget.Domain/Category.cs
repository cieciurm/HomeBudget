namespace HomeBudget.Domain
{
    public class Category : BaseEntityWithId
    {
        public string Name { get; set; }

        public Category RootCategory { get; set; }
        public int RootCategoryId { get; set; }
    }
}