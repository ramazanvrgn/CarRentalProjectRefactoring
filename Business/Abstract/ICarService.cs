using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface ICarService
    {
        DataResult<List<Car>> GetAll();
        DataResult<List<Car>> GetByModelYear(decimal min,decimal max);
        DataResult<List<Car>> GetCarsByBrandId(int _brandId);
        DataResult<List<Car>> GetCarsByColorId(int _colorId);
        DataResult<List<CarDetailDto>>  GetCarDetail();
        Result Add(Car car);
        Result Update(Car car);
        Result Delete(Car car);
    }
}
