using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService
    {
        IDataResult<List<User>> GetAll();
        User GetById(int userId);
        List<UserDetailDto> GetUserDetails();
        IResult Add(User user);
    }
}
