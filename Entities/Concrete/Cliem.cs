using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete
{
    public class Cliem:IEntity
    {
        [Key]
        public int cliem_id { get; set; }
        public string cliem_title { get; set; }

    }
}
