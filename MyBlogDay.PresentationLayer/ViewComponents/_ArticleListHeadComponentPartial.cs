using Microsoft.AspNetCore.Mvc;

namespace MyBlogDay.PresentationLayer.ViewComponents
{
    public class _ArticleListHeadComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke() //
        {
            return View();
        }
    }
}
