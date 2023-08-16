using MicroserviceDemo.Core.Utilities.Results.Abstract;
using MicroserviceDemo.Entities.Concrete;
using MicroserviceDemo.Entities.Dtos;
using MicroserviceDemo.Entities.JWT;

namespace MicroserviceDemo.Business.Abstract
{
    public interface IAuthService
    {
        IDataResult<User> Register(UserForRegisterDto userForRegisterDto, string password);
        IDataResult<User> Login(UserForLoginDto userForLoginDto);
        IResult UserExists(string email);
        IDataResult<AccessToken> CreateAccessToken(User user);
        IResult Logout(string email);
    }
}
