using RecapProject.Business.Concrete;
using RecapProject.DataAccess.Concrete.EntityFramework;
using RecapProject.DataAccess.Concrete.InMemory;
using RecapProject.Entities;
using System;
using System.Collections.Generic;

namespace RecapProject
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            carManager.Add(new Car { CarId = 1, BrandId = 2, ColorId = 3, DailyPrice = 55000, ModelYear = 2016, Description = "Audi A3" });
            carManager.Delete(new Car { CarId = 6});

            Console.WriteLine(carManager.GetAll());
            
            
        }
    }
}
