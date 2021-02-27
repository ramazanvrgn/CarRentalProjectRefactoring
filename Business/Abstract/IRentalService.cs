using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IRentalService
    {
        DataResult<List<Rental>> GetAll();
        DataResult<List<Rental>> GetById(int _rentalId);
        Result Add(Rental rental);
        Result Update(Rental rental);
        Result Delete(Rental rental);
    }
}
