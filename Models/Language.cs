using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SplitwiseDemo.Models
{
    public class Language
    {
        [Key]
        public int languageid { get; set; }
        public string language_name { get; set; }
        public ICollection<User> user { get; set; }
    }
}
