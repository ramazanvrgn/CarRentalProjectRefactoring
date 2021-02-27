using Business.Abstract;
using Business.Constans;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
   public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public Result Add(Brand brand)
        {
           
           _brandDal.Add(brand);
            return new SuccessResult(Messages.BrandsAdded);
        }

        public Result Delete(Brand brand)
        {
            _brandDal.Delete(brand);

            return new SuccessResult(Messages.BrandsDeleted);

        }

        public DataResult<List<Brand>> GetAll()
        {
            
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll(), Messages.BrandsListed);
        }

        public DataResult<List<Brand>> GetById(int _brandId)
        {
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll(b => b.Id == _brandId));

            
        }

        public Result Update(Brand brand)
        {
            _brandDal.Update(brand);
            return new SuccessResult(Messages.BrandsUpdated);



        }
    }
}
