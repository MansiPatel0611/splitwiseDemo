using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SplitwiseDemo.Models
{
    public class Settelments
    {
        [Key]
        public int settelmentid { get; set; }

        public User payer { get; set; }

        public User payee { get; set; }

        public double paid_amount { get; set; }
        public DateTime paid_on { get; set; }

        public int bill_id { get; set; }
        [ForeignKey("bill_id")]
        public Bill bill { get; set; }
    }
}
