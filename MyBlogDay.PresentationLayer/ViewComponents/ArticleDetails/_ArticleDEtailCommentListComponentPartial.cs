using Microsoft.AspNetCore.Mvc;
using MyBlogDayBusinesLayer.Abstract;

namespace MyBlogDay.PresentationLayer.ViewComponents.ArticleDetails
{
    public class _ArticleDEtailCommentListComponentPartial : ViewComponent
    {
        private readonly ICommentService _commentService;

        public _ArticleDEtailCommentListComponentPartial(ICommentService commentService)
        {
            _commentService = commentService;
        }

        public IViewComponentResult Invoke(int id)
        {
            var value = _commentService.TGetCommentsByArticleId(id);
            return View(value);
        }
    }
}
