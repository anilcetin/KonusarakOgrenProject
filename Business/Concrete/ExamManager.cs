using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ExamManager : IExamService
    {
        IExamDal _examDal;

        public ExamManager(IExamDal examDal)
        {
            _examDal = examDal;
        }

        public IResult Add(Exam exam)
        {
            _examDal.Add(exam);
            return new SuccessResult("Sınav eklendi");
        }

        public IResult Delete(Exam exam)
        {
            _examDal.Delete(exam);
            return new SuccessResult("Sınav silindi");
        }

        public IDataResult<List<Exam>> GetAll()
        {
            return new SuccessDataResult<List<Exam>>(_examDal.GetAll(), "Sınavlar listelendi");
        }

        public IDataResult<Exam> GetById(int exam_id)
        {
            return new SuccessDataResult<Exam>(_examDal.Get(u => u.exam_id == exam_id), "Sınav numarasına göre data getirildi.");
        }

        public IDataResult<List<ExamContentDto>> GetExamAllDetails(int exam_id)
        {
            return new SuccessDataResult<List<ExamContentDto>>(_examDal.GetExamAllDetails(exam_id), "Sınav detayları listelendi");
        }

        public IDataResult<List<ExamDetailDto>> GetExamDetails()
        {
            return new SuccessDataResult<List<ExamDetailDto>>(_examDal.GetExamDetails(), "Sınav detayları listelendi");
        }

        public IResult Update(Exam exam)
        {
            _examDal.Update(exam);
            return new SuccessResult("Sınav güncellendi");
        }
    }
}
