using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IAnswerService
    {
        IDataResult<List<Answer>> GetAll();
        IDataResult<List<Answer>> GetByQuestionId(int question_id);
        IResult Add(Answer answer);
        IResult Delete(Answer answer);
        IResult Update(Answer answer);
    }
}
