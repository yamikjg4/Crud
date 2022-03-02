using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Models
{
    public class User
    {
        [Key]
       public int id;
        [Required]
        [Display(Name = "User Name")]
        public string name { get; set; }
        [Display(Name = "Password")]
        public string pwd { get; set; }
    }
}
