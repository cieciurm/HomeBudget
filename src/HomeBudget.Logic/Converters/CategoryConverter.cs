using HomeBudget.Contracts;
using HomeBudget.Domain;

namespace HomeBudget.Logic.Converters
{
    public class CategoryConverter : IViewModelConverter<CategoryViewModel, Category>
    {
        public CategoryViewModel Convert(Category model)
        {
            if (model == null)
                return null;

            return new CategoryViewModel
            {
                Id = model.Id,
                CreationDate = model.CreationDate,
                Name = model.Name,
            };
        }

        public Category Convert(CategoryViewModel viewModel)
        {
            if (viewModel == null)
                return null;

            return new Category
            {
                Name = viewModel.Name,
            };
        }
    }
}
