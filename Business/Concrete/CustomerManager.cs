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
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public Result Add(Customer customer)
        {

            _customerDal.Add(customer);
            return new SuccessResult(Messages.CustomerAdded);
        }

        public Result Delete(Customer customer)
        {
            _customerDal.Delete(customer);
            return new SuccessResult(Messages.CustomerDeleted);
        }

        public DataResult<List<Customer>> GetAll()
        {
            
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(),Messages.CustomersListed);
        }

        public DataResult<List<Customer>> GetById(int _customerId)
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(c=>c.CustomerId==_customerId));
        }

        public Result Update(Customer customer)
        {
            _customerDal.Update(customer);
            return new SuccessResult(Messages.CustomerUpdated);
        }
    }
}
