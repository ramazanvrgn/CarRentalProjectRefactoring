using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IUserService
    {
        DataResult<List<User>> GetAll();
        DataResult<List<User>> GetById(int _userId);
        Result Add(User user);
        Result Update(User user);
        Result Delete(User user);
    }
}
