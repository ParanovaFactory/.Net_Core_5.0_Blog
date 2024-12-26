using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Conrete
{
    public class SocialMedialManager : ISocialMediaService
    {
        ISocialMediaDal _socialMeadilDal;

        public SocialMedialManager(ISocialMediaDal socialMeadilDal)
        {
            _socialMeadilDal = socialMeadilDal;
        }

        public List<SocialMedia> GetList()
        {
            return _socialMeadilDal.GetList();
        }

        public void TAdd(SocialMedia t)
        {
            _socialMeadilDal.Insert(t);
        }

        public void TDelete(SocialMedia t)
        {
            _socialMeadilDal.Delete(t);
        }

        public SocialMedia TGetById(int id)
        {
            return _socialMeadilDal.GetById(id);
        }

        public void TUpdate(SocialMedia t)
        {
            _socialMeadilDal.Update(t);
        }
    }
}
