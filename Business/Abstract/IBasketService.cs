using Business.Generics;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBasketService:IGenericCrudOperationService<Basket>
    {
        IDataResult<List<BasketDetailDto>> GetBasketDetails();
        IDataResult<List<BasketDetailDto>> GetBasketDetailsByUserId(int userId);
    }
}
