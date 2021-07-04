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
    public interface IProductService : IGenericCrudOperationService<Product>
    {
        IDataResult<List<ProductDetailDto>> GetProductDetails();
        IDataResult<List<ProductDetailDto>> GetProductDetailByCategoryId(int categoryId);
        IDataResult<List<ProductDetailDto>> GetProductDetailByProductId(int productId);
        IDataResult<List<ProductDetailDto>> GetProductDetailByBrandId(int brandId);

        IDataResult<Product> GetById(int productId);
        IDataResult<List<Product>> GetAllByCategory(int categoryId);


    }
}
