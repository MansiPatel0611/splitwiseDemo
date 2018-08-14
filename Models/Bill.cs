using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SplitwiseDemo.Models
{
    public class Bill
    {
        public int billid { get; set; }
        public string description { get; set; }
        public double total_amount { get; set; }

        //public int bill_created_by_id { get; set; }
        //[ForeignKey("bill_created_by_id")]
        public User bill_created_by { get; set; }

        //public int bill_updated_by_id { get; set; }
        //[ForeignKey("bill_updated_by_id")]
        public User bill_updated_by { get; set; }

        public DateTime bill_date { get; set; }
        public DateTime bill_created_at { get; set; }
        public DateTime bill_updated_at { get; set; }

        [ForeignKey("groupid")]
        public Group group_id { get; set; }

        public ICollection<Payer> payers { get; set; }
        public ICollection<SharedWith> sharedwiths { get; set; }
        public ICollection<Settelments> settelments { get; set; }


    }
}
