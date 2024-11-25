using MyBlogDayEntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogDayDataAccessLayer.Abstract
{
    public interface IArticleDal : IGenericDal<Article>
    {
        List<Article> ArticleListWithCategory();  
        List<Article> ArticleListWithCategoryAndAppUser();
        Article GetLastArticle();

    }
}
