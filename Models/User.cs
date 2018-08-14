using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SplitwiseDemo.Models
{
    public class User
    {
        public int userid { get; set; }
        public string user_name { get; set; }
        public string email_id { get; set; }
        public string password { get; set; }
        public string phone_no { get; set; }
        public byte[] profile_pic { get; set; }

        [ForeignKey("currencyid")]
        public Currency currency_id { get; set; }

        [ForeignKey("timezoneid")]
        public Timezone timezone_id { get; set; }

        [ForeignKey("languageid")]
        public Language language_id { get; set; }

        public DateTime created_on { get; set; }
        public DateTime updated_on { get; set; }


        public ICollection<GroupMember> groupmembers { get; set; }

        public ICollection<Group> group { get; set; }

        [InverseProperty("bill_created_by")]
        public ICollection<Bill> bill_creater { get; set; }
        [InverseProperty("bill_updated_by")]
        public ICollection<Bill> bill_updater { get; set; }

        [InverseProperty("user_id")]
        public ICollection<Friend> user_friend { get; set; }
        [InverseProperty("friend_to")]
        public ICollection<Friend> friend_to { get; set; }

        [InverseProperty("shared_with")]
        public ICollection<SharedWith> billpayer { get; set; }
        [InverseProperty("owes_to")]
        public ICollection<SharedWith> billpayee { get; set; }

        public ICollection<Payer> payers { get; set; }

        [InverseProperty("payer")]
        public ICollection<Settelments> settelmentpayer { get; set; }
        [InverseProperty("payee")]
        public ICollection<Settelments> settelmentpayee { get; set; }
    }
}
