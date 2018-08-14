using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SplitwiseDemo.Models
{
    public class Group
    {
        public int groupid { get; set; }
        public string group_name { get; set; }
        public DateTime group_created_on { get; set; }

        public int group_created_by { get; set; }
        [ForeignKey("group_created_by")]
        public User user { get; set; }

        public bool is_simplified_depts { get; set; }

        public ICollection<GroupMember> groupmembers { get; set; }
        public ICollection<Bill> bills { get; set; }

    }
}
