﻿using RecapProject.Business.Abstract;
using RecapProject.DataAccess.Abstract;
using RecapProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RecapProject.Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;

        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();

        }
    }
}