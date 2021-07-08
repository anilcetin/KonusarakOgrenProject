using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CliemManager : ICliemService
    {
        ICliemDal _cliemDal;
        public CliemManager(ICliemDal cliemDal)
        {
            _cliemDal = cliemDal;
        }

        public IResult Add(Cliem cliem)
        {
            _cliemDal.Add(cliem);
            return new SuccessResult("Yetki eklendi");
        }

        public IResult Delete(Cliem cliem)
        {
            _cliemDal.Delete(cliem);
            return new SuccessResult("Yetki silindi");
        }

        public IDataResult<List<Cliem>> GetAll()
        {
            return new SuccessDataResult<List<Cliem>>(_cliemDal.GetAll(), "Yetkiler listelendi");
        }

        public IDataResult<Cliem> GetById(int cliem_id)
        {
            return new SuccessDataResult<Cliem>(_cliemDal.Get(u => u.cliem_id == cliem_id), "Yetki numarasına göre data getirildi.");
        }

        public IResult Update(Cliem cliem)
        {
            try
            {
                _cliemDal.Update(cliem);
                return new SuccessResult("Güncelleme başarılı.");
            }
            catch (Exception)
            {
                return new ErrorResult("Tüm bilgileri eksiksiz giriniz.");
                throw;
            }
        }
    }
}
