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
            return new SuccessResult("Yetki eklendi");
        }

        public IResult Delete(Question question)
        {
            _questionDal.Delete(question);
            return new SuccessResult("Yetki silindi");
        }

        public IDataResult<List<Question>> GetAll()
        {
            return new SuccessDataResult<List<Question>>(_questionDal.GetAll(), "Yetkiler listelendi");
        }

        public IDataResult<List<Question>> GetByArticleId(int article_id)
        {
            return new SuccessDataResult<List<Question>>(_questionDal.GetAll(u=> u.articlequestion == article_id), "Yetki numarasına göre data getirildi.");
        }

        public IResult Update(Question question)
        {
            try
            {
                _questionDal.Update(question);
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
