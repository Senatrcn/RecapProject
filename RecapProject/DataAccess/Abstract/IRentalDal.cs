using RecapProject.Core.DataAccess;
using RecapProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace RecapProject.DataAccess.Abstract
{
    public interface IRentalDal: IEntityRepository<Rental>
    {
    }
}
