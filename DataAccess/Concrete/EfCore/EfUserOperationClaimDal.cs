using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EfCore.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EfCore
{
    public class EfUserOperationClaimDal:EfEntityRepositoryBase<UserOperationClaim,ShopContext>,IUserOperationClaimDal
    {
    }
}
