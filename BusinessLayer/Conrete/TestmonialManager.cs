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
    public class TestmonialManager : ITestmonialService
    {
        ITestmonialDal _testmanialDal;

        public TestmonialManager(ITestmonialDal testmanialDal)
        {
            _testmanialDal = testmanialDal;
        }

        public List<Testmonial> GetList()
        {
            return _testmanialDal.GetList();
        }

        public void TAdd(Testmonial t)
        {
            _testmanialDal.Insert(t);
        }

        public void TDelete(Testmonial t)
        {
            _testmanialDal.Delete(t);
        }

        public Testmonial TGetById(int id)
        {
            return _testmanialDal.GetById(id);
        }

        public void TUpdate(Testmonial t)
        {
            _testmanialDal.Update(t);
        }
    }
}
