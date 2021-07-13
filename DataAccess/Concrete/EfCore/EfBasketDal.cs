using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EfCore.Context;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EfCore
{
    public class EfBasketDal : EfEntityRepositoryBase<Basket, ShopContext>, IBasketDal
    {
       
        //public List<BasketDetailDto> GetBasketDetails(Expression<Func<BasketDetailDto, bool>> filter = null)
        //{
        //    using (ShopContext context = new ShopContext())
        //    {
        //        var result = from basket in context.Baskets
        //                     join product in context.Products on basket.ProductId equals product.Id
        //                     join brand in context.Brands on basket.BrandId equals brand.Id
        //                     join user in context.Users on basket.UserId equals user.Id
        //                     select new BasketDetailDto
        //                     {
        //                         BasketId = basket.Id,
        //                         UserId = user.Id,
        //                         ProductId = product.Id,
        //                         BrandName = brand.Name,
        //                         ProductName = product.Name,
        //                         UserFullName = $"{user.FirstName} {user.LastName}",
        //                         Price = product.Price,
        //                         Images = (from i in context.ProductImages where i.ProductId == product.Id select i.ImagePath).ToList(),
        //                         Count = basket.Count,
        //                         CreatedDate = basket.CreateDate,
        //                         Active = basket.Active
        //                     };
        //        return filter == null ? result.ToList() : result.Where(filter).ToList();
        //    }
        //}
    }
}
