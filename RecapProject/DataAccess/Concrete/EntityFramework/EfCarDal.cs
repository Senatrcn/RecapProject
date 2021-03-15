using RecapProject.DataAccess.Abstract;
using RecapProject.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using RecapProject.DataAccess.Concrete.EntityFramework.Context;
using RecapProject.Core.DataAccess.EntityFramework;

namespace RecapProject.DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCapDbContext> ,ICarDal
    {
        
        
    }
}
