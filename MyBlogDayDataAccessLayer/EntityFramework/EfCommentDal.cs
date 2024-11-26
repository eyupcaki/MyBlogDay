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
	public class EfCommentDal : GenericRepositories<Comment>, ICommentDal
	{
		public EfCommentDal(SensiveContext context) : base(context)
		{
		}


		public List<Comment> GetCommentsByArticleId(int id)
		{
			var context=new SensiveContext();
			var values = context.Comments.Where(x => x.ArticleId == id).Include(y=>y.Article).Include(z=>z.AppUser).ToList();
			return values;
		}

    }
}
