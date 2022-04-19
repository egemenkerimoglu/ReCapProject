using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    // Bellekte çalışacak şekilde kodlayalım
    public class InMemoryCarDal : ICarDal
    {
        // Veri varmış gibi davranacağımız için
        List<Car> _cars;
        // Proje başlatılınca bellekte araba listesi oluştur
        public InMemoryCarDal()
        {// Uygulama çaşıştığı anda
            _cars = new List<Car>
            {
                new Car{Id=1,BrandId=1,ColorId=1,DailyPrice=500,ModelYear="2021",Description="Spor"},
                new Car{Id=2,BrandId=1,ColorId=2,DailyPrice=590,ModelYear="2012",Description="Spor"},
                new Car{Id=3,BrandId=2,ColorId=1,DailyPrice=700,ModelYear="2019",Description="Aile Arabası"},
                new Car{Id=4,BrandId=2,ColorId=3,DailyPrice=490,ModelYear="2008",Description="Binek"},
                new Car{Id=5,BrandId=2,ColorId=1,DailyPrice=750,ModelYear="2022",Description="Sedan"},
            };
        }


        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            // LINQ
            Car carToDelete = _cars.SingleOrDefault(c=>c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

              

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c=>c.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
        }

    }
}
