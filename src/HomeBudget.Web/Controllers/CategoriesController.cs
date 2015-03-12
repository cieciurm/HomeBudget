using System.Web.Mvc;
using HomeBudget.Contracts;
using HomeBudget.Logic;

namespace HomeBudget.Web.Controllers
{
    public class CategoriesController:BaseController
    {
        private readonly ICategoriesService _categoriesService;

        public CategoriesController(ICategoriesService categoriesService)
        {
            _categoriesService = categoriesService;
        }

        public ActionResult Index()
        {
            var viewModel = _categoriesService.GetAllCategories();

            return View(viewModel);
        }

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(CategoryViewModel model)
        {
            if (ModelState.IsValid)
            {
                _categoriesService.AddCategory(model);
                UnitOfWork.Commit();

                return RedirectToAction("Index");
            }

            return View();
        }

        public ActionResult Edit(int id)
        {
            var viewModel = _categoriesService.GetCategory(id);

            if (viewModel == null)
                return View("Error");

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Edit(CategoryViewModel model)
        {
            if (ModelState.IsValid)
            {
                _categoriesService.UpdateCategory(model);

                UnitOfWork.Commit();

                return RedirectToAction("Index");
            }

            return View();
        }

        public ActionResult Delete(int id)
        {
            var viewModel = _categoriesService.GetCategory(id);

            return View(viewModel);
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeletePost(int id)
        {
            _categoriesService.DeleteCategory(id);

            UnitOfWork.Commit();

            return RedirectToAction("Index");
        }
    }
}