using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.DTOs
{
    public class UserDetailDto:IDto
    {
        public int user_id { get; set; }
        public string user_email { get; set; }
        public string cliem_title { get; set; }
    }
}
