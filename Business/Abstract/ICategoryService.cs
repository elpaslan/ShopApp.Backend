﻿using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        IDataResult<List<Category>> GetList();
        IResult Add(Category category);
        IResult MultiAdd(Category[] categories);
        IResult Delete(Category category);
        IResult Update(Category category);
    }
}
