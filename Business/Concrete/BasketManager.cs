using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BasketManager : IBasketService
    {
        private readonly IBasketDal _basketDal;

        public BasketManager(IBasketDal basketDal)
        {
            _basketDal = basketDal;
        }
        public IResult Add(Basket basket)
        {
            _basketDal.Add(basket);
            return new SuccessResult(Messages.AddedBasket);
        }

        public IResult Delete(Basket basket)
        {
            _basketDal.Delete(basket);
            return new SuccessResult(Messages.DeletedBasket);
        }

        public IDataResult<List<Basket>> GetAll()
        {
            return new SuccessDataResult<List<Basket>>(_basketDal.GetAll());
        }

        public IDataResult<List<BasketDetailDto>> GetBasketDetails()
        {
            return new SuccessDataResult<List<BasketDetailDto>>(_basketDal.GetBasketDetails());
        }

        public IDataResult<List<BasketDetailDto>> GetBasketDetailsByUserId(int userId)
        {
            return new SuccessDataResult<List<BasketDetailDto>>(_basketDal.GetBasketDetails(x => x.UserId == userId));
        }

        public IResult Update(Basket basket)
        {
            _basketDal.Update(basket);
            return new SuccessResult(Messages.UpdatedBasket);
        }
    }
}
