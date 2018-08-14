using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SplitwiseDemo.Models
{
    public class GroupMember
    {
        [Key]
        public int memberid { get; set; }

        [ForeignKey("userid")]
        public User user_id { get; set; }
        //public User user { get; set; }

        [ForeignKey("groupid")]
        public Group group_id { get; set; }
        //public Group group { get; set; }

    }
}
