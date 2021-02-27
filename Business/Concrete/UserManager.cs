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
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public Result Add(User user)
        {

            _userDal.Add(user);
            return new SuccessResult(Messages.UserAdded);
        }

        public Result Delete(User user)
        {
            _userDal.Delete(user);
            return new SuccessResult(Messages.UserDeleted);
        }

        public DataResult<List<User>> GetAll()
        {

            return new SuccessDataResult<List<User>>(_userDal.GetAll(), Messages.UsersListed);
        }

        public DataResult<List<User>> GetById(int _userId)
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll(c => c.UserId == _userId));
        }

        public Result Update(User user)
        {
            _userDal.Update(user);
            return new SuccessResult(Messages.UserUpdated);
        }
    }
}
