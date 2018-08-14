using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SplitwiseDemo.Models
{
    public class Currency
    {
        public int currencyid { get; set; }
        public string currency_name { get; set; }
        public string currency_symbol { get; set; }
        public ICollection<User> user { get; set; }
    }
}
