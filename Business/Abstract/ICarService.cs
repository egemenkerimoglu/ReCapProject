using Core.Utilities.Result;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();// tüm arabaları listeler
        IDataResult<Car> GetById(int carId); // cartını getir
        IDataResult<List<Car>> GetCarsByBrandId(int id);// Markasına göre getir
        IDataResult<List<Car>> GetCarsByColorId(int id); // Rengine göre getir        
        IDataResult<List<CarDetailDto>> GetCarDetails();//joinlenen tablo yapıs
        IResult Add(Car car);



    }
}
