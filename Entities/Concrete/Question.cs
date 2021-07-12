using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete
{
    public class Question : IEntity
    {
        [Key]
        public int question_id { get; set; }
        public string question_title { get; set; }
        public int articlequestion { get; set; }
    }
}
