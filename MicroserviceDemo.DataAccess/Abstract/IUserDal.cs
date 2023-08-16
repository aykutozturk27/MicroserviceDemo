using MicroserviceDemo.Core.DataAccess;
using MicroserviceDemo.Entities.Concrete;

namespace MicroserviceDemo.DataAccess.Abstract
{
    public interface IUserDal : IEntityRepository<User>
    {
        List<OperationClaim> GetClaims(User user);
    }
}
