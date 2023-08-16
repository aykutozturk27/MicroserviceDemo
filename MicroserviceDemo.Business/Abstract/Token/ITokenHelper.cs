using MicroserviceDemo.Entities.Concrete;
using MicroserviceDemo.Entities.JWT;

namespace MicroserviceDemo.Business.Abstract.Token
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
    }
}
