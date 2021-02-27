using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IBrandService
    {
        DataResult<List<Brand>> GetAll();
        DataResult<List<Brand>> GetById(int _brandId);
        Result Add(Brand brand);
        Result Update(Brand brand);
        Result Delete(Brand brand);
    }
}
