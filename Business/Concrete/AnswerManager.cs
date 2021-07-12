using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class AnswerManager : IAnswerService
    {
        IAnswerDal _answerDal;

        public AnswerManager(IAnswerDal answerDal)
        {
            _answerDal = answerDal;
        }

        public IResult Add(Answer answer)
        {
            _answerDal.Add(answer);
            return new SuccessResult("Cevap eklendi");
        }

        public IResult Delete(Answer answer)
        {
            _answerDal.Delete(answer);
            return new SuccessResult("Cevap silindi");
        }

        public IDataResult<List<Answer>> GetAll()
        {
            return new SuccessDataResult<List<Answer>>(_answerDal.GetAll(), "Cevaplar listelendi");
        }

        public IDataResult<List<Answer>> GetByQuestionId(int question_id)
        {
            return new SuccessDataResult<List<Answer>>(_answerDal.GetAll(u => u.questionanswer == question_id), "Cevap numarasına göre data getirildi.");
        }

        public IResult Update(Answer answer)
        {
            _answerDal.Update(answer);
            return new SuccessResult("Cevap güncellendi");
        }
    }
}
