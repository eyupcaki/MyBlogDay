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
	public class EfNewsLatterDal : GenericRepositories<NewsLetter>, INewsletterDal
	{
		public EfNewsLatterDal(SensiveContext context) : base(context)
		{
		}
	}
}
