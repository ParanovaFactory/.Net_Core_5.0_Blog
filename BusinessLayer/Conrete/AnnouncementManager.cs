﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Conrete
{
    public class AnnouncementManager : IAnnoncementService
    {
        IAnnoncementDal _announcementDal;

        public AnnouncementManager(IAnnoncementDal announcementDal)
        {
            _announcementDal = announcementDal;
        }

        public List<Announcement> GetList()
        {
            return _announcementDal.GetList();
        }

        public void TAdd(Announcement t)
        {
            _announcementDal.Insert(t);
        }

        public void TDelete(Announcement t)
        {
            _announcementDal.Delete(t);
        }

        public Announcement TGetById(int id)
        {
            return _announcementDal.GetById(id);
        }

        public void TUpdate(Announcement t)
        {
            _announcementDal.Update(t);
        }
    }
}
