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
	public class EfTagCloudDal : GenericRepositories<TagCloud>, ITagCloudDal
	{
		public EfTagCloudDal(SensiveContext context) : base(context)
		{
		}
	}
}
