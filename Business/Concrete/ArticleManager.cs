using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ArticleManager : IArticleService
    {
        IArticleDal _articleDal;

        public ArticleManager(IArticleDal articleDal)
        {
            _articleDal = articleDal;
        }

        public IResult Add(Article article)
        {
            _articleDal.Add(article);
            return new SuccessResult("Makale eklendi");
        }

        public IResult AddAutomatically()
        {
            // otomatik 5 adet çekip eklenecek kodlar buraya gelecek kontol edilecek eğer eklenen son 5 makale ile şuan istenen 5 makale aynı ise eklenmeyecek
            throw new NotImplementedException();
        }

        public IResult Delete(Article article)
        {
            _articleDal.Delete(article);
            return new SuccessResult("Makale silindi");
        }

        public IDataResult<List<Article>> GetAll()
        {
            return new SuccessDataResult<List<Article>>(_articleDal.GetAll(), "Yetkiler listelendi");
        }

        public IDataResult<Article> GetById(int article_id)
        {
            return new SuccessDataResult<Article>(_articleDal.Get(u => u.article_id == article_id), "Yetki numarasına göre data getirildi.");
        }

        public IResult Update(Article article)
        {
            _articleDal.Update(article);
            return new SuccessResult("Makale güncellendi");
        }
    }
}
