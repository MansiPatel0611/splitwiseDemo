using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SplitwiseDemo.Models
{
    public class Friend
    {
        public int friendid { get; set; }

        public User user_id { get; set; }
        public User friend_to { get; set; }
        public bool splitwise_status { get; set; }
    }
}
