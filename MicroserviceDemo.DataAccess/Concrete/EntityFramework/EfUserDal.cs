using MicroserviceDemo.Core.DataAccess.EntityFramework;
using MicroserviceDemo.DataAccess.Abstract;
using MicroserviceDemo.DataAccess.Concrete.EntityFramework.Contexts;
using MicroserviceDemo.Entities.Concrete;

namespace MicroserviceDemo.DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, MicroserviceDemoContext>, IUserDal
    {
        public List<OperationClaim> GetClaims(User user)
        {
            using (var context = new MicroserviceDemoContext())
            {
                var result = from operationClaim in context.OperationClaims
                             join userOperationClaim in context.UserOperationClaims
                                 on operationClaim.Id equals userOperationClaim.OperationClaimId
                             where userOperationClaim.UserId == user.Id
                             select new OperationClaim { Id = operationClaim.Id, Name = operationClaim.Name };
                return result.ToList();

            }
        }
    }
}
