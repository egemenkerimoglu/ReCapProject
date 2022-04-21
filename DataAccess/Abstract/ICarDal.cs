using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;

namespace DataAccess.Abstract
{
    // Car Tablosnunun Veri erişim katmanı (Data access layer)
    // Ekle sil güncelle getir gibi operasyonlar
    public interface ICarDal : IEntityRepository<Car>
    {
        // Car tablosuna özgü 
        List<CarDetailDto> GetCarDetails();

    }
}
