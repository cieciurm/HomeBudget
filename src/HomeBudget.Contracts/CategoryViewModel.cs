using System.ComponentModel.DataAnnotations;
using HomeBudget.Contracts.Resources;

namespace HomeBudget.Contracts
{
    public class CategoryViewModel : BaseEntityViewModel
    {
        [Required(ErrorMessageResourceType = typeof(CategoryViewModelResources), ErrorMessageResourceName = "NameCannotBeEmpty")]
        [Display(Name = "Name", ResourceType = typeof(CategoryViewModelResources))]
        public string Name { get; set; }

        [Required(ErrorMessageResourceType = typeof(CategoryViewModelResources), ErrorMessageResourceName = "DescriptionCannotBeEmpty")]
        [Display(Name = "Description", ResourceType = typeof(CategoryViewModelResources))]
        public string Description { get; set; }
    }
}
