using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
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

        public IResult Add(User user)
        {
            if (user.user_email.Length < 5)
            {   
                return new ErrorResult("Email minimum 5 karakter olabilir");
            }
            _userDal.Add(user);
            return new SuccessResult(Messages.UserAdded);
        }

        public List<User> GetAll()
        {
            return _userDal.GetAll();
        }

        public User GetById(int userId)
        {
            return _userDal.Get(u => u.user_id == userId);
        }

        public List<UserDetailDto> GetUserDetails()
        {
            return _userDal.GetUserDetails();
        }
    }
}
