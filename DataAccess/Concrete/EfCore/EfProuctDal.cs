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
    public class EfProuctDal : EfEntityRepositoryBase<Product, ShopContext>, IProductDal
    {
        public List<ProductDetailDto> GetProductDetails(Expression<Func<ProductDetailDto, bool>> filter = null)
        {
            using (ShopContext context = new ShopContext())
            {
                var result = from product in context.Products
                             join category in context.Categories
                                 on product.CategoryId equals category.CategoryId
                             join brand in context.Brands
                                 on product.BrandId equals brand.Id
                             select new ProductDetailDto
                             {
                                 ProductId = product.Id,
                                 BrandId = brand.Id,
                                 CategoryId = category.CategoryId,
                                 Images =
                                     (from i in context.ProductImages where i.ProductId == product.Id select i.ImagePath).ToList(),
                                 CategoryName = category.Name,
                                 BrandName = brand.Name,
                                 ProductName = product.Name,
                                 Description = product.Description,
                                 Code = product.Code,
                                 DiscountRate = product.DiscountRate,
                                 Price = product.Price,
                                 CreateDate = product.CreateDate,
                                 Active = product.Active,

                             };
                return filter == null ? result.ToList() : result.Where(filter).ToList();
            }
        }
    }
}
