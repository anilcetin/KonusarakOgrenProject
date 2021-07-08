using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICliemService
    {
        IDataResult<List<Cliem>> GetAll();
        IDataResult<Cliem> GetById(int cliem_id);
        IResult Add(Cliem cliem);
        IResult Delete(Cliem cliem);
        IResult Update(Cliem cliem);
    }
}
