using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Id : "+ car.Id + "Açıklama : " + car.Description + " Model : " + car.ModelYear + " Renk :" + car.Id);
            }

            foreach (var car in carManager.GetCarsByBrandId(1))
            {
                Console.WriteLine("Markası 1 Olan Arabalar :" + car.Description);
            }

            foreach(var car in carManager.GetCarsByColorId(1))
            {
                Console.WriteLine("Rengi 1  * Beyaz olna araçalar " + car.Description);
            }
        }
    }
}
