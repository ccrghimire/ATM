using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ATMDetails.Models
{
    public class ATMDetailContext : DbContext
    {
        public ATMDetailContext() :base("yourConnectionString") // web config ma halne 
        {

        }

        public DbSet<ATMConfig> ATMConfig { get; set; }
        public DbSet<Bank> Banks { get; set; }


    }
}