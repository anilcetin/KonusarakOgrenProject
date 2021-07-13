using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class ExamContentDto: IDto
    {
        public int exam_id { get; set; }
        public string article_title { get; set; }
        public string article_content { get; set; }
        public string question_title { get; set; }
        public string answer_content { get; set; }
        public int answer_is_true { get; set; }


    }
}
