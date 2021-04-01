using RecapProject.Core.Entities.Concrete;
using RecapProject.Core.Utilities.Results;
using RecapProject.Core.Utilities.Security.JWT;
using RecapProject.Entities.Concrete;
using RecapProject.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace RecapProject.Business.Abstract
{
    public interface IAuthService
    {
        IDataResult<User> Register(UserForRegisterDto userForRegisterDto, string password);
        IDataResult<User> Login(UserForLoginDto userForLoginDto);
        IResult UserExists(string email);
        IDataResult<AccessToken> CreateAccessToken(User user);
    }
}
