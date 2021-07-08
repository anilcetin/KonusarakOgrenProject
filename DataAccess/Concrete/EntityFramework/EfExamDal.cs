using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfExamDal : EfEntityRepositoryBase<Exam, KonusaraOgrenContext>, IExamDal
    {
        public List<ExamDetailDto> GetExamDetails()
        {
            using (KonusaraOgrenContext context = new KonusaraOgrenContext())
            {
                var result = from e in context.Exams
                             join a in context.Articles
                             on e.articleexam equals a.article_id
                             select new ExamDetailDto
                             {
                                 exam_id = e.exam_id,
                                 article_title = a.article_title,
                                 exam_date = e.exam_date
                             }; 
                return result.ToList();
            }
        }
    }
}
