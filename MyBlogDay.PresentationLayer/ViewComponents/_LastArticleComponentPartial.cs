﻿using Microsoft.AspNetCore.Mvc;
using MyBlogDayBusinesLayer.Abstract;

namespace MyBlogDay.PresentationLayer.ViewComponents
{
    public class _LastArticleComponentPartial : ViewComponent
    {
        private readonly IArticleService _articleService;

        public _LastArticleComponentPartial(IArticleService articleService)
        {
            _articleService = articleService;
        }

        public IViewComponentResult Invoke()
        {
            var value = _articleService.TGetLastArticle();
            return View();
        }
    }
}