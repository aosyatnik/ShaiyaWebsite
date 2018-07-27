using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ShaiyaWebsite.Models
{
    public class User
    {
        public User()
        {
            RegistrationDate = DateTime.Now;
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        [Index(IsUnique = true)]
        public string Login { get; set; }

        [Required]
        [MaxLength(100)]
        public string Password { get; set; }

        public int Points { get; set; }
        public DateTime RegistrationDate { get; set; }
    }
}