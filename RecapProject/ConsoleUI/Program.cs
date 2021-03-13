using RecapProject.Business.Concrete;
using RecapProject.DataAccess.Concrete.InMemory;
using System;
using System.Collections.Generic;

namespace RecapProject
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description + "\t" + car.ModelYear);
            }

            
            
        }
    }
}
