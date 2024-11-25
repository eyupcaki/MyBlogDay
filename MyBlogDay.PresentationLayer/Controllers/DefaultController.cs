using Microsoft.AspNetCore.Mvc;
using MyBlogDayBusinesLayer.Abstract;

namespace MyBlogDay.PresentationLayer.Controllers
{
    public class DefaultController : Controller
    {
        private readonly IArticleService    _articleService;

        public DefaultController(IArticleService articleService)
        {
            _articleService = articleService;
        }

        public IActionResult ArticleList()
        {
            var values=_articleService.TArticleListWithCategoryAndAppUser();
            return View(values);
        }
    }
}
