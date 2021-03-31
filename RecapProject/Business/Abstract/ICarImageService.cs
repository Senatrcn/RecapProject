using Microsoft.AspNetCore.Http;
using RecapProject.Core.Utilities.Results;
using RecapProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace RecapProject.Business.Abstract
{
    public interface ICarImageService
    {
        IResult Add(CarImage carImage, IFormFile file);
        IResult Delete(CarImage carImage);
        IResult Update(CarImage carImage, IFormFile file);
        IResult GetById(int carImageId);
        IDataResult<List<CarImage>> GetAll();
        IDataResult<List<CarImage>> GetByCarId(int carId);
    }
}
