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
                                 exam_date = e.exam_date,
                                 article_content = a.article_content
                             }; 
                return result.ToList();
            }
        }

        public List<ExamContentDto> GetExamAllDetails(int exam_id)
        {
            using (KonusaraOgrenContext context = new KonusaraOgrenContext())
            {
                var result = from e in context.Exams
                             join a in context.Articles on e.articleexam equals a.article_id
                             join q in context.Questions on a.article_id equals q.articlequestion
                             join aw in context.Answers on q.question_id equals aw.questionanswer
                             where e.exam_id == exam_id
                             select new ExamContentDto
                             {
                                 exam_id = e.exam_id,
                                 article_title = a.article_title,
                                 article_content = a.article_content,
                                 question_title = q.question_title,
                                 answer_content = aw.answer_content,
                                 answer_is_true = aw.answer_is_true
                             };
                return result.ToList();
            }
        }

    }
}
