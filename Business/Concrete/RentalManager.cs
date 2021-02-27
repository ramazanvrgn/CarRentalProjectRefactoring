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
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public Result Add(Rental rental)
        {
            var result =_rentalDal.GetAll(r=>r.CarId==rental.CarId && r.ReturnDate.Date<=rental.RentDate.Date) ;           
 
            if (result.Count==0)
            {
                return new ErrorResult(Messages.RentalInvalid);
            }
            else
            {
                _rentalDal.Add(rental);
                return new SuccessResult(Messages.RentalAdded);
            }
            
        }

        public Result Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.RentalDeleted);
        }

        public DataResult<List<Rental>> GetAll()
        {

            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(), Messages.RentalsListed);
        }

        public DataResult<List<Rental>> GetById(int _rentalId)
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(c => c.RentalId == _rentalId));
        }

        public Result Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult(Messages.RentalUpdated);
        }
        
    }
}
