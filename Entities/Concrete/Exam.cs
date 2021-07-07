using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete
{
    public class Exam:IEntity
    {
        [Key]
        public int exam_id { get; set; }
        public string exam_date { get; set; }
        public string articleexam { get; set; }

    }
}
