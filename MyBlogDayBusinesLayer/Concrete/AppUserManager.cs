using MyBlogDayBusinesLayer.Abstract;
using MyBlogDayDataAccessLayer.Abstract;
using MyBlogDayEntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogDayBusinesLayer.Concrete
{
    public class AppUserManager : IAppUserService
    {
        private readonly IAppUserDal _appUserDal;

        public AppUserManager(IAppUserDal appUserDal)
        {
            _appUserDal = appUserDal;
        }

        public void TDelete(int id)
        {
            throw new NotImplementedException();
        }

        public List<AppUser> TGetAll()
        {
            return  _appUserDal.GetAll();
        }

        public AppUser TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TInsert(AppUser entity)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(AppUser entity)
        {
            throw new NotImplementedException();
        }
    }
}
