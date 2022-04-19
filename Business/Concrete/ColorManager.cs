﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal __colorDal;

        public ColorManager(IColorDal colorDal)
        {
            __colorDal = colorDal;
        }

        public List<Color> GetAll()
        {
            return __colorDal.GetAll();
        }
    }
}
