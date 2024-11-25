using Microsoft.EntityFrameworkCore;
using MyBlogDayDataAccessLayer.Abstract;
using MyBlogDayDataAccessLayer.Context;
using MyBlogDayDataAccessLayer.Repositories;
using MyBlogDayEntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogDayDataAccessLayer.EntityFramework
{
	public class EfArticleDal : GenericRepositories<Article>, IArticleDal
	{
		public EfArticleDal(SensiveContext context) : base(context)
		{
		}

		public List<Article> ArticleListWithCategory()
		{
			var context = new SensiveContext();
			var values=context.Articles.Include(x=>x.Category).ToList();
			return values;

		}

		public List<Article> ArticleListWithCategoryAndAppUser()
		{
			var context = new SensiveContext();
			var values = context.Articles.Include(x => x.Category).Include(y=>y.AppUser).ToList();
			return values;
		}

		public Article GetLastArticle()
		{
			var context = new SensiveContext();
			var value=context.Articles.OrderByDescending(x=>x.ArticleId).Take(1).FirstOrDefault();
			return value;
		}
	}
}
