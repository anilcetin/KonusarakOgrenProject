using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete
{
    public class Answer:IEntity
    {
        [Key]
        public int answer_id { get; set; }
        public string answer_content { get; set; }
        public int answer_is_true { get; set; }
        public int questionanswer { get; set; }
    }
}
