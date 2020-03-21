using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ATMDetails.Models;

namespace ATMDetails.Controllers
{
    public class HomeController : Controller
    {
        private const int V = 33;

        public ActionResult Index()
        {
            ATMDetailContext db = new ATMDetailContext();  // yo database sanga kura garna


            // aaba bank haru ko object banaune

            //Bank firstbankObject = new Bank();
            //firstbankObject = new Bank();
            //firstbankObject.BankName = "ADBL";
            //firstbankObject.HeadOffice = "Dharamshahpath";


            // aaba 2nd bank ko object banaune

            //Bank secondbankObject = new Bank();
            //secondbankObject.BankName = "BOK";
            //secondbankObject.HeadOffice = "Kamaladi";

            //aaba bank ko object haru Database ma add gare

            //Bank thirdbankObject = new Bank();
            //thirdbankObject.BankName = "Century";
            //thirdbankObject.HeadOffice = "Putalisadak";

            //Bank fourthbankObject = new Bank();
            //fourthbankObject.BankName = "Citizens";
            //fourthbankObject.HeadOffice = "Narayanhiti";

            //Bank fifthbankObject = new Bank();
            //fifthbankObject.BankName = "Civil";
            //fifthbankObject.HeadOffice = "Kamaladi";
            
            //Bank sixthbankObject = new Bank();
            //sixthbankObject.BankName = "Everest";
            //sixthbankObject.HeadOffice = "Lazimpat";

            //Bank seventhbankObject = new Bank();
            //seventhbankObject.BankName = "Excel development";
            //seventhbankObject.HeadOffice = "Birtamod";

            //Bank eightbankObject = new Bank();
            //eightbankObject.BankName = "Gandaki";
            //eightbankObject.HeadOffice = "Pokhara";

            //Bank ninebankObject = new Bank();
            //ninebankObject.BankName = "Garima";
            //ninebankObject.HeadOffice = "Lazimpat";

            //Bank tenbankObject = new Bank();
            //tenbankObject.BankName = "Global IME";
            //tenbankObject.HeadOffice = "Panipokhari";

            //Bank elevenbankObject = new Bank();
            //elevenbankObject.BankName = "Himalayan Bank";
            //elevenbankObject.HeadOffice = "Lazimpat";

            //Bank twelvebankObject = new Bank();
            //twelvebankObject.BankName = "ICFC Finance";
            //twelvebankObject.HeadOffice = "Bhatbhateni Baluwatar";

            //Bank thirteenbankObject = new Bank();
            //thirteenbankObject.BankName = "IME Cooperative";
            //thirteenbankObject.HeadOffice = "Kantipath";

            //Bank fourteenbankObject = new Bank();
            //fourteenbankObject.BankName = "Jyoti Bikas";
            //fourteenbankObject.HeadOffice = "Kamaladi";
            
            //Bank fifteenbankObject = new Bank();
            //fifteenbankObject.BankName = "Kailash";
            //fifteenbankObject.HeadOffice = "Putalisadak";
            
            //Bank sixteenbankObject = new Bank();
            //sixteenbankObject.BankName = "Kamana";
            //sixteenbankObject.HeadOffice = "Gyaneshwor";

            //Bank seventeenbankObject = new Bank();
            //seventeenbankObject.BankName = "Kumari";
            //seventeenbankObject.HeadOffice = "Tangal";

            //Bank eighteenbankObject = new Bank();
            //eighteenbankObject.BankName = "Laxmi";
            //eighteenbankObject.HeadOffice = "Hattisar";

            //Bank nineteenbankObject = new Bank();
            //nineteenbankObject.BankName = "Lumbini";
            //nineteenbankObject.HeadOffice = "Dillibazar";

            //Bank twentybankObject = new Bank();
            //twentybankObject.BankName = "Mahalaxmi";
            //twentybankObject.HeadOffice = "Durbarmarg";

            //Bank twentyonebankObject = new Bank();
            //twentyonebankObject.BankName = "Manjushree";
            //twentyonebankObject.HeadOffice = "Baneshwor";

            //Bank twentytwobankObject = new Bank();
            //twentytwobankObject.BankName = "Machhapuchchhree";
            //twentytwobankObject.HeadOffice = "Lazimpat";

            //Bank twentythreebankObject = new Bank();
            //twentythreebankObject.BankName = "Mega";
            //twentythreebankObject.HeadOffice = "Gyaneshwor";

            //Bank twentyfourbankObject = new Bank();
            //twentyfourbankObject.BankName = "Muktinath";
            //twentyfourbankObject.HeadOffice = "Kamaladi";

            //Bank twentyfivebankObject = new Bank();
            //twentyfivebankObject.BankName = "Nabil";
            //twentyfivebankObject.HeadOffice = "Teendhara";

            //Bank twentysixbankObject = new Bank();
            //twentysixbankObject.BankName = "NBB";
            //twentysixbankObject.HeadOffice = "Ghantaghar";

            //Bank twentysevenbankObject = new Bank();
            //twentysevenbankObject.BankName = "NCC";
            //twentysevenbankObject.HeadOffice = "Bagbazar";

            //Bank twentyeightbankObject = new Bank();
            //twentyeightbankObject.BankName = "Nepal Bank";
            //twentyeightbankObject.HeadOffice = "Ramshahpat Newroad";

            //Bank twentyninebankObject = new Bank();
            //twentyninebankObject.BankName = "NIBL";
            //twentyninebankObject.HeadOffice = "Durbarmarg";

            //Bank thirtybankObject = new Bank();
            //thirtybankObject.BankName = "NIC Asia";
            //thirtybankObject.HeadOffice = "Thapathali";

            //Bank thirtyonebankObject = new Bank();
            //thirtyonebankObject.BankName = "NMB";
            //thirtyonebankObject.HeadOffice = "Babarmahal";

            //Bank thirtytwobankObject = new Bank();
            //thirtytwobankObject.BankName = "NSBI";
            //thirtytwobankObject.HeadOffice = "Kesarmahal";

            //Bank thirtythreebankObject = new Bank();
            //thirtythreebankObject.BankName = "Pokhara Finance";
            //thirtythreebankObject.HeadOffice = "Pokhara";

            //Bank thirtyfourbankObject = new Bank();
            //thirtyfourbankObject.BankName = "Prabhu";
            //thirtyfourbankObject.HeadOffice = "Bbabrmahal";

            //Bank thirtyfivebankObject = new Bank();
            //thirtyfivebankObject.BankName = "Prime";
            //thirtyfivebankObject.HeadOffice = "Kamalpokhari";

            //Bank thirtysixbankObject = new Bank();
            //thirtysixbankObject.BankName = "Sangrila";
            //thirtysixbankObject.HeadOffice = "Baluwatar";

            //Bank thirtysevenbankObject = new Bank();
            //thirtysevenbankObject.BankName = "Sanima";
            //thirtysevenbankObject.HeadOffice = "Alkapuri Naxal";

            //Bank thirtyeightbankObject = new Bank();
            //thirtyeightbankObject.BankName = "SCB";
            //thirtyeightbankObject.HeadOffice = "Baneshwor";

            //Bank thirtyninebankObject = new Bank();
            //thirtyninebankObject.BankName = "Siddhartha";
            //thirtyninebankObject.HeadOffice = "Hattisar";

            //Bank fourtybankObject = new Bank();
            //fourtybankObject.BankName = "Sunrise";
            //fourtybankObject.HeadOffice = "Gairidhara";

            //Bank fourtyonebankObject = new Bank();
            //fourtyonebankObject.BankName = "Best Finance";
            //fourtyonebankObject.HeadOffice = "Kamaladi";

            //Bank fourtytwobankObject = new Bank();
            //fourtytwobankObject.BankName = "Tinau Mission";
            //fourtytwobankObject.HeadOffice = "Butwal";

            //Bank fourtythreebankObject = new Bank();
            //fourtythreebankObject.BankName = "Sahayogi";
            //fourtythreebankObject.HeadOffice = "Janakpur";

            //Bank fourtyfourbankObject = new Bank();
            //fourtyfourbankObject.BankName = "Shine Resunga";
            //fourtyfourbankObject.HeadOffice = "Bhairahawa";

            //Bank fourtyfivebankObject = new Bank();
            //fourtyfivebankObject.BankName = "Goodwill Finance";
            //fourtyfivebankObject.HeadOffice = "Hattisar";



            //db.Banks.Add(firstbankObject);
            //db.Banks.Add(fourtybankObject);
            //db.Banks.Add(thirdbankObject);
            //db.Banks.Add(fourthbankObject);
            //db.Banks.Add(fifthbankObject);
            //db.Banks.Add(sixthbankObject);
            //db.Banks.Add(seventhbankObject);
            //db.Banks.Add(eightbankObject);
            //db.Banks.Add(ninebankObject);
            //db.Banks.Add(tenbankObject);
            //db.Banks.Add(elevenbankObject);
            //db.Banks.Add(twelvebankObject);
            //db.Banks.Add(thirteenbankObject);
            //db.Banks.Add(fourteenbankObject);
            //db.Banks.Add(fifteenbankObject);
            //db.Banks.Add(sixteenbankObject);
            //db.Banks.Add(seventeenbankObject);
            //db.Banks.Add(eighteenbankObject);
            //db.Banks.Add(nineteenbankObject);
            //db.Banks.Add(twentybankObject);
            //db.Banks.Add(twentyonebankObject);
            //db.Banks.Add(twentytwobankObject);
            //db.Banks.Add(twentythreebankObject);
            //db.Banks.Add(twentyfourbankObject);
            //db.Banks.Add(twentyfivebankObject);
            //db.Banks.Add(twentysixbankObject);
            //db.Banks.Add(twentysevenbankObject);
            //db.Banks.Add(twentyeightbankObject);
            //db.Banks.Add(twentyninebankObject);
            //db.Banks.Add(thirtybankObject);
            //db.Banks.Add(thirtyonebankObject);
            //db.Banks.Add(thirtytwobankObject);
            //db.Banks.Add(thirtythreebankObject);
            //db.Banks.Add(thirtyfourbankObject);
            //db.Banks.Add(thirtyfivebankObject);
            //db.Banks.Add(thirtysixbankObject);
            //db.Banks.Add(thirtysevenbankObject);
            //db.Banks.Add(thirtyeightbankObject);
            //db.Banks.Add(thirtyninebankObject);
            //db.Banks.Add(fourtybankObject);
            //db.Banks.Add(fourtyonebankObject);
            //db.Banks.Add(fourtytwobankObject);
            //db.Banks.Add(fourtythreebankObject);
            //db.Banks.Add(fourtyfourbankObject);
            //db.Banks.Add(fourtyfivebankObject);

            // aaba Save garne

            db.SaveChanges();


            //ATMConfig config1 = new ATMConfig();
            //config1.SerialNo = "56HG801234";
            //config1.ModelNo = "280 RL";
            //config1.Location = "thapathali";
            //config1.Number_of_cassettes = "4 Cassettes";
            //config1.Cassette_key = "245h65";
            //config1.Receipt_printer = "yes";
            //config1.Journal_printer = "yes";
            //config1.Card_Reader = "Moto CH2V2CU";
            //config1.EPP = "V6";
            //config1.Processor = "intel i3";
            //config1.RAM = "4 GB";
            //config1.Hard_Disk = "500 GB";
            //config1.CPU_Model = "5G";
            //config1.LCD_Type = "15 inch";
            //config1.FDK_Allignment = "bottom";
            //config1.Vault = "digital";
            //config1.Single_Reject = "yes";
            //config1.Camera = "2 camera";
            //config1.Operating_System = "win 10";
            //config1.Prosetup = "12.30";
            //config1.Probase = "31.10";
            //config1.NDC = "31.10";
            //config1.EMV_Level = "3.2 kernel";
            //config1.System_Key = "2435g55";
            //config1.Installation_Date = new DateTime(year: 2020, month: 1, day: 13);
            //config1.BankId = V;

            //db.ATMConfig.Add(config1);
            db.SaveChanges();


            return View();
        }

        [HttpGet]
        public ActionResult ATMinput()
        {
            ATMDetailContext db = new ATMDetailContext();
            List<Bank> banks = db.Banks.ToList();
            

            return View(banks);
        }
        [HttpPost]
        public ActionResult ATMinput(ATMConfig submittedATMvalue)

        {
            ATMDetailContext db = new ATMDetailContext();
            db.ATMConfig.Add(submittedATMvalue);
            db.SaveChanges();


            return View();

        } 
            public ActionResult About()
        {
            ViewBag.Message = "ATM CONFIGURATION";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "CONTACT: ELITE SOLUTIONSM PVT.LTD.  01-5260517";

            return View();
        }
    }
}