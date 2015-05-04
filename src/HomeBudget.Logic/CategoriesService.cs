using System.Collections.Generic;
using System.Linq;
using HomeBudget.Contracts;
using HomeBudget.Domain;
using HomeBudget.Logic.Converters;
using HomeBudget.Logic.Extensions;
using HomeBudget.Mapping.Abstraction;

namespace HomeBudget.Logic
{
    public interface ICategoriesService
    {
        IEnumerable<CategoryViewModel> GetAllCategories();
        CategoryViewModel GetCategory(int categoryId);
        void AddCategory(CategoryViewModel model);
        void UpdateCategory(CategoryViewModel model);
        void DeleteCategory(int categoryId);
    }

    public class CategoriesService : ICategoriesService
    {
        private readonly IRepository<Category> _categoriesRepository;
        private readonly IViewModelConverter<CategoryViewModel, Category> _converter;

        public CategoriesService(IRepository<Category> categoriesRepository, IViewModelConverter<CategoryViewModel, Category> converter)
        {
            _categoriesRepository = categoriesRepository;
            _converter = converter;
        }

        public IEnumerable<CategoryViewModel> GetAllCategories()
        {
            return _categoriesRepository.Query()
                .GetNotDeleted()
                .Select(_converter.Convert);
        }

        public CategoryViewModel GetCategory(int categoryId)
        {
            return _converter.Convert(_categoriesRepository.Query().SingleOrDefault(x=>x.Id == categoryId));
        }

        public void AddCategory(CategoryViewModel model)
        {
            _categoriesRepository.Add(_converter.Convert(model));
        }

        public void UpdateCategory(CategoryViewModel model)
        {
            var category = _categoriesRepository.Query().SingleOrDefault(x => x.Id == model.Id);

            if (category == null)
                return;

            category.Name = model.Name;

            _categoriesRepository.Edit(category);
        }

        public void DeleteCategory(int categoryId)
        {
            var category = _categoriesRepository.Query().SingleOrDefault(x => x.Id == categoryId);

            if (category == null)
                return;

            category.IsDeleted = true;

            _categoriesRepository.Edit(category);
        }
    }
}
