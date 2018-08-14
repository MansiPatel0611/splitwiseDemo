using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SplitwiseDemo.Models
{
    public class Timezone
    {
        [Key]
        public int timezoneid { get; set; }
        public string timezone_name { get; set; }
        public ICollection<User> user { get; set; }
    }
}
