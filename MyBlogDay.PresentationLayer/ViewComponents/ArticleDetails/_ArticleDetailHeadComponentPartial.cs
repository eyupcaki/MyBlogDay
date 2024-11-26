using Microsoft.AspNetCore.Mvc;

namespace MyBlogDay.PresentationLayer.ViewComponents.ArticleDetails
{
	public class _ArticleDetailHeadComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View(); 
		}
	}
}
