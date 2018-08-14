using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SplitwiseDemo.Models
{
    public class Payer
    {
        public int payerid { get; set; }

        public int paid_by { get; set; }
        [ForeignKey("paid_by")]
        public User user { get; set; }
        //public User paid_by { get; set; }

        public double amount_paid { get; set; }

        public int bill_id { get; set; }
        [ForeignKey("bill_id")]
        public Bill bill { get; set; }
    }
}
