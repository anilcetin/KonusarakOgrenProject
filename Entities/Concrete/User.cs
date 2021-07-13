using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete
{
    public class User : IEntity
    {
        [Key]
        public int user_id { get; set; }
        public string user_email { get; set; }
        public string user_password { get; set; }
        public int cliemuser { get; set; }

    }
}
