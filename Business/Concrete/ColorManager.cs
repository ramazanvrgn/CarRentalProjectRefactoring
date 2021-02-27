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
   public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public Result Add(Color color)
        {            
            _colorDal.Add(color);
            return new SuccessResult(Messages.ColorsAdded);
        }

        public Result Delete(Color color)
        {
            _colorDal.Delete(color);
            return new SuccessResult(Messages.ColorsDeleted);


        }

        public DataResult<List<Color>> GetAll()
        {
            return new SuccessDataResult<List<Color>>( _colorDal.GetAll(),Messages.ColorsListed);
        }

        public DataResult<List<Color>> GetById(int _colorId)
        {
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll(c => c.Id == _colorId));            
        }

        public Result Update(Color color)
        {
            _colorDal.Update(color);
            return new SuccessResult(Messages.ColorsUpdated);


        }
    }
}
