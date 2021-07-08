using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IArticleService
    {
        IDataResult<List<Article>> GetAll();
        IDataResult<Article> GetById(int article_id);
        IResult Add(Article article);
        IResult AddAutomatically();
        IResult Delete(Article article);
        IResult Update(Article article);
    }
}
