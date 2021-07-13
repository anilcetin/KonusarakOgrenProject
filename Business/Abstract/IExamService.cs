using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IExamService
    {
        IDataResult<List<Exam>> GetAll();
        IDataResult<Exam> GetById(int exam_id);
        IResult Add(Exam exam);
        IResult Delete(Exam exam);
        IResult Update(Exam exam);

        IDataResult<List<ExamDetailDto>> GetExamDetails();
        IDataResult<List<ExamContentDto>> GetExamAllDetails(int exam_id);
    }
}
