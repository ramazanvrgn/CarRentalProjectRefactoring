using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface ICustomerService
    {
        DataResult<List<Customer>> GetAll();
        DataResult<List<Customer>> GetById(int _customerId);
        Result Add(Customer customer);
        Result Update(Customer customer);
        Result Delete(Customer customer);
    }
}
