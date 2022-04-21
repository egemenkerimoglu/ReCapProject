using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    // Car Tablosnunun Veri erişim katmanı (Data access layer)
    // Ekle sil güncelle getir gibi operasyonlar
    public interface ICarDal:IEntityRepository<Car>
    {
      
    }
}
