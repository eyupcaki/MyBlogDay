using MyBlogDayBusinesLayer.Abstract;
using MyBlogDayBusinesLayer.Concrete;
using MyBlogDayDataAccessLayer.Abstract;
using MyBlogDayDataAccessLayer.EntityFramework;
using MyBlogDayEntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogDayBusinesLayer.Concrete
{

	public class ArticleManager : IArticleService
	{
		private readonly IArticleDal _articleDal;

		public ArticleManager(IArticleDal articleDal)
		{
			_articleDal = articleDal;
		}

		public void TDelete(int id)
		{
			_articleDal.Delete(id);
		}

		public List<Article> TGetAll()
		{
			return _articleDal.GetAll();
		}

		public List<Article> TArticleListWithCategory()
		{
			return _articleDal.ArticleListWithCategory();
		}

		public Article TGetById(int id)
		{
			return _articleDal.GetById(id);
		}

        public Article TGetLastArticle()
		{
			return _articleDal.GetLastArticle();
		}

        public void TInsert(Article entity)
		{
			_articleDal.Insert(entity);
		}

		public void TUpdate(Article entity)
		{
			if(entity.Description!="" && entity.Title.Length>=5 && entity.Title.Length<=100)
			{
				_articleDal.Update(entity);
			}
			else
			{
				//hata mesajı
			}

		}

		public List<Article> TArticleListWithCategoryAndAppUser()
		{
			return _articleDal.ArticleListWithCategoryAndAppUser();
		}
	}
}
