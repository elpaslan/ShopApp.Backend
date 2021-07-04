using Core.Utilities.Results;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace Business.Generics
{
    public interface IGenericImagesService<T>
    {
        IResult Add(IFormFile file, T entity);
        IResult Delete(T entity);
        IResult Update(IFormFile file, T entity);
        IDataResult<T> Get(int id);
        IDataResult<List<T>> GetAll();
        IDataResult<List<T>> GetImagesById(int id);
    }
}
