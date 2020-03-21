using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ATMDetails.Models
{
    public class ATMConfig
    {
        public int Id { get; set; }                    
        public String SerialNo { get; set; }          
        public String ModelNo { get; set; }
        public string Location { get; set; }
        public String Number_of_cassettes { get; set; }
        public String Cassette_key { get; set; }
        public String Receipt_printer { get; set; }
        public String Journal_printer { get; set; }
        public String Card_Reader { get; set; }
        public String EPP { get; set; }
        public String Processor { get; set; }
        public String RAM { get; set; }
        public String Hard_Disk { get; set; }
        public String CPU_Model { get; set; }
        public String LCD_Type { get; set; }
        public String FDK_Allignment { get; set; }
        public String Vault { get; set; }
        public String Single_Reject { get; set; }
        public String Camera { get; set; }
        public String Operating_System { get; set; }
        public String Prosetup { get; set; }
        public String Probase { get; set; }
        public String NDC { get; set; }
        public String EMV_Level { get; set; }
        public String System_Key { get; set; }
        public DateTime Installation_Date { get; set; }

        [ForeignKey("Bank")]
        public int BankId { get; set; }
        public virtual Bank Bank { get; set; }
    }

}