using Core.Utilities.Results;
using System.Collections.Generic;

namespace Business.Generics
{
    public interface IGenericCrudOperationService<T>
    {
        IDataResult<List<T>> GetAll();
        IResult Add(T entity);
        IResult Delete(T entity);
        IResult Update(T entity);
    }
}
