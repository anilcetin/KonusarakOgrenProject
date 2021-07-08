using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class ExamDetailDto: IDto
    {
        public int exam_id { get; set; }
        public string article_title { get; set; }
        public DateTime exam_date { get; set; }

    }
}
