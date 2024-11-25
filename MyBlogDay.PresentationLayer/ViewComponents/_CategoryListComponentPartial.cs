using Microsoft.AspNetCore.Mvc;
using MyBlogDayBusinesLayer.Abstract;

namespace MyBlogDay.PresentationLayer.ViewComponents
{
    public class _CategoryListComponentPartial : ViewComponent
    {
        private readonly ICategoryService _categoryService;

        public _CategoryListComponentPartial(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _categoryService.TGetAll();
            return View(values);
        }
    }
}
