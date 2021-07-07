using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete
{
    public class Article:IEntity
    {
        [Key]
        public int article_id { get; set; }
        public string article_title { get; set; }
        public string article_content { get; set; }
    }
}
