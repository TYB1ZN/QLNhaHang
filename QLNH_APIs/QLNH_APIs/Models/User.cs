using System;
using System.ComponentModel.DataAnnotations;

namespace QLNH_APIs.Models
{
    public class User
    {
        [Key]
        public int id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

    }
}
