using RecapProject.Core.Entities.Concrete;
using RecapProject.Core.Utilities.Results;
using RecapProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace RecapProject.Business.Abstract
{
    public interface IUserService
    {
        IResult Add(User user);
        IResult Delete(User user);
        IResult Update(User user);
        IDataResult<List<User>> GetAll();
        IDataResult<User> GetById(int userId);

        List<OperationClaim> GetClaims(User user);
        User GetByMail(string email);
    }
}
