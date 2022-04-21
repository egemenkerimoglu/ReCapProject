using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();// tüm arabaları listeler
        Car GetById(int carId); // cartını getir
        List<Car> GetCarsByBrandId(int id);// Markasına göre getir
        List<Car> GetCarsByColorId(int id); // Rengine göre getir

       
    }
}
