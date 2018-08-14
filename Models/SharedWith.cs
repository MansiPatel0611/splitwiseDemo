using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SplitwiseDemo.Models
{
    public class SharedWith
    {
        [Key]
        public int sharedid { get; set; }

        public User shared_with { get; set; }
        public double owes_amount { get; set; }


        public int bill_id { get; set; }
        [ForeignKey("bill_id")]
        public Bill bill { get; set; }

        public User owes_to { get; set; }
    }
}
