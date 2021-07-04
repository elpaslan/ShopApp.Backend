using Business.Abstract;
using Core.Utilities.Helpers;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductImageManager : IProductImagesService
    {
        private IProductImageDal _productImageDal;

        public ProductImageManager(IProductImageDal productImageDal)
        {
            _productImageDal = productImageDal;
        }

        public IResult Add(IFormFile file, ProductImage productsImage)
        {
            var imageCount = _productImageDal.GetAll(i => i.ProductId == productsImage.ProductId).Count;
            if (imageCount>=5)
            {
                return new ErrorResult("One product must have 5 or less images");
            }
            var imageResult = FileHelper.Upload(file);
            if (!imageResult.Success)
            {
                return new ErrorResult(imageResult.Message);
            }
            productsImage.ImagePath = imageResult.Message;
            _productImageDal.Add(productsImage);
            return new SuccessResult("Product image added");
        }

        public IResult Delete(ProductImage productImage)
        {
            _productImageDal.Delete(productImage);
            return new SuccessResult();
        }

        public IResult Update(IFormFile file, ProductImage productImage)
        {
            _productImageDal.Update(productImage);
            return new SuccessResult();
        }

        public IDataResult<ProductImage> Get(int id)
        {
            return new SuccessDataResult<ProductImage>(_productImageDal.Get(i => i.Id == id));
        }

        public IDataResult<List<ProductImage>> GetAll()
        {
            return new SuccessDataResult<List<ProductImage>>(_productImageDal.GetAll());
        }

        public IDataResult<List<ProductImage>> GetImagesById(int id)
        {
            throw new NotImplementedException();
        }

        
    }
}
