using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class QuestionManager : IQuestionService
    {
        IQuestionDal _questionDal;

        public QuestionManager(IQuestionDal questionDal)
        {
            _questionDal = questionDal;
        }

        public IResult Add(Question question)
        {
            _questionDal.Add(question);
            return new SuccessResult("Cevap eklendi");
        }

        public IResult Delete(Question question)
        {
            _questionDal.Delete(question);
            return new SuccessResult("Cevap silindi");
        }

        public IDataResult<List<Question>> GetAll()
        {
            return new SuccessDataResult<List<Question>>(_questionDal.GetAll(), "Cevaplar listelendi");
        }

        public IDataResult<Question> GetById(int quesiton_id)
        {
            return new SuccessDataResult<Question>(_questionDal.Get(u => u.question_id == quesiton_id), "Cevap numarasına göre data getirildi.");
        }

        public IResult Update(Question question)
        {
            _questionDal.Update(question);
            return new SuccessResult("Cevap güncellendi");
        }
    }
}
