using Microsoft.AspNetCore.Mvc;
using MyBlogDayBusinesLayer.Abstract;
using MyBlogDayEntityLayer.Concrete;
using System.Windows.Input;

namespace MyBlogDay.PresentationLayer.Controllers
{
    public class CommentController : Controller
    {
        private readonly ICommentService _commentService;

        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        [HttpGet]
        public PartialViewResult AddComment()
        {
            return PartialView();
        }

        [HttpPost]
        public IActionResult AddComment(Comment comment)
        {
            comment.CreatedDate = DateTime.Now;
          //  comment.ArticleId = 0;
            comment.AppUserId = 1;
            _commentService.TInsert(comment);
            return RedirectToAction("ArticleList", "Default");
        }
    }
}
