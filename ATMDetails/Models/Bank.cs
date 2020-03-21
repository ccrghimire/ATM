using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ATMDetails.Models
{
    public class Bank
    {
        public int Id { get; set; }
        public String BankName { get; set; }

        public string HeadOffice { get; set; }

        public virtual ICollection<ATMConfig> ATMConfig { get; set; }
    }
}
