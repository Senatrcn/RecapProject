using RecapProject.Core.DataAccess;
using RecapProject.Core.Entities.Concrete;
using RecapProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace RecapProject.DataAccess.Abstract
{
    public interface IUserDal: IEntityRepository<User>
    {
        List<OperationClaim> GetClaims(User user);
    }
}
