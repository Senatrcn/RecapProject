using RecapProject.DataAccess.Abstract;
using RecapProject.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RecapProject.DataAccess.Concrete.EntityFramework.Context;
using RecapProject.Core.DataAccess.EntityFramework;
using RecapProject.Entities.Dtos;
using RecapProject.Entities.Concrete;
using System.Linq.Expressions;

namespace RecapProject.DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCapDbContext>, ICarDal
    {

        public List<CarDetailDto> GetCarDetails()
        {
            using(ReCapDbContext context = new ReCapDbContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join clr in context.Colors
                             on c.ColorId equals clr.ColorId
                             select new CarDetailDto
                             {
                                 BrandName = b.Name,
                                 ColorName = clr.Name,
                                 CarName = c.Description,
                                 DailyPrice = c.DailyPrice

                             };
                return result.ToList();
            }
        }

       
    }
}
