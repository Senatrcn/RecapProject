using RecapProject.Core.Entities.Concrete;
using RecapProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace RecapProject.Core.Utilities.Security.JWT
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
    }
}
