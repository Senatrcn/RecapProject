using RecapProject.Core.DataAccess;
using RecapProject.Entities;
using RecapProject.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace RecapProject.DataAccess.Abstract
{
    public interface ICarDal: IEntityRepository<Car>
    {
        List<CarDetailDto> GetCarDetails();
   
    }
}
