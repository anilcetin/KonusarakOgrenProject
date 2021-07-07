using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

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
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(user.user_email);
            if (user.user_email.Length < 5)
            {   
                return new ErrorResult("Email minimum 5 karakter olabilir");
            }
            if (match.Success == false)
            {
                return new ErrorResult("Email formatı uygun değil");
            }
            _userDal.Add(user);
            return new SuccessResult(Messages.UserAdded);
        }

        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll(), "Kullanıcılar listelendi");
        }

        public IDataResult<User> GetById(int userId)
        {
            return new SuccessDataResult<User>(_userDal.Get(u => u.user_id == userId), "Kullanıcı numarasına göre data getirildi.");
        }

        public IDataResult<List<UserDetailDto>> GetUserDetails()
        {
            return new SuccessDataResult<List<UserDetailDto>>(_userDal.GetUserDetails(),"Kullanıcı maili ve yetkisi listelendi");
        }

        public IResult Login(string email, string password)
        {
            var result = _userDal.Get(u => u.user_email == email && u.user_password == password);
            if(result == null)
            {
                return new ErrorDataResult<User>("Kullanıcı adı veya şifre hatalı");
            }
            return new SuccessDataResult<User>("Giriş başarılı");
        }
    }
}
