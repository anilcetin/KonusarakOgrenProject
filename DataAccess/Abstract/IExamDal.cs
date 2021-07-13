using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IExamDal : IEntityRepository<Exam>
    {
        List<ExamDetailDto> GetExamDetails();
        List<ExamContentDto> GetExamAllDetails(int exam_id);
    }
}
