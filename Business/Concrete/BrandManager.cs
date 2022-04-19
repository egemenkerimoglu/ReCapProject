using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal __brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            __brandDal = brandDal;
        }

        public List<Brand> GetAll()
        {
            return __brandDal.GetAll();
        }
    }
}
