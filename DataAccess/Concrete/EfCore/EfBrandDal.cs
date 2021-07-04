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
    public class EfBrandDal : EfEntityRepositoryBase<Brand, ShopContext>, IBrandDal
    {
        //public List<BrandDetailDto> GetBrandDetails(Expression<Func<BrandDetailDto, bool>> filter = null)
        //{
        //    using (ShopContext context = new ShopContext())
        //    {
        //        var result = from brand in context.Brands
        //                     select new BrandDetailDto
        //                     {
        //                         BrandId = brand.Id,
        //                         BrandName = brand.Name,
        //                         Images = (from images in context.BrandImages where images.BrandId == brand.Id select images.ImagePath).ToList()
        //                     };
        //        return filter == null ? result.ToList() : result.Where(filter).ToList();
        //    }
        //}
    }
}
