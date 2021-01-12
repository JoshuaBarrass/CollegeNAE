using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace NEAapp.Classes
{
    class Customer
    {
        string CompanyName;
        List<Site> companySites = new List<Site>();
        Billing billingInformation;
        string keyContacts;
        string MainAddress;
        string threeLetterCode;
        string TechnicalContacts;
        string CompanyEmail;

        public Customer(string Name, string TLC, string keyCon, string techCon, string CompanyEmail)
        {

            this.CompanyName = Name;
            this.keyContacts = keyCon;
            this.TechnicalContacts = techCon;
            this.threeLetterCode = TLC;
            this.CompanyEmail = CompanyEmail;

        }

        public Customer()
        {

        } //Empty Constructor so i can do it in a later void 

        public void init(string Name, string TLC, string keyCon, string techCon, string CompanyEmail)
        {
            this.CompanyName = Name;
            this.keyContacts = keyCon;
            this.TechnicalContacts = techCon;
            this.threeLetterCode = TLC;
            this.CompanyEmail = CompanyEmail;
        }

        public void AddSite(string Name, string Address, bool MainSite, string internet, string phone, string printers)
        {
            this.companySites.Add(new Site(Name, Address, MainSite, internet, phone, printers));
            UpdateMain();
        }

        private void UpdateMain()
        {
            string mainAddress = this.companySites.Find(site => site.isMain() == true).getAddress();
            if(mainAddress != null)
                this.MainAddress = mainAddress; //Find site where this is true
            else           
                this.MainAddress = this.companySites.First<Site>().getAddress(); //else use first site added
            
        }

        public void bumpEmailUnpaidInvoices()
        {
            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential("neacompanyproject@gmail.com", "alwafpdwqmmixcyk"),
                EnableSsl = true,
                
            };


            //Get unpaid Invoices

            var newMail = new MailMessage
            {
                From = new MailAddress("neacompanyproject@gmail.com"),
                Subject = $"Unpaid Invoice - Urgent Invoice to be paid for {Program.Company}",
                Body = @"

<!-- HTML Codes by Quackit.com -->
<!DOCTYPE html>
<title>Text Example</title>
<style>
div.container {
background - color: #ffffff;
}
div.container p {
text - align: center;
font-family: Arial;
font-size: 18px;
font-style: normal;
font-weight: bold;
text-decoration: none;
text-transform: none;
color: #000000;
background-color: #ffffff;
}
</style>

<div class='container'>"+
$"<p>{ this.CompanyName } - URGENT INVOICE PAYMENTS MISSED </p>" + 
$"</ div >  <p> Please Contact {Program.CompanyContactNumber} Urgently to resolve this issue </p> <p></p> <p> Thank you for your cooperation</p>",
                IsBodyHtml = true,
            };

            newMail.To.Add(this.CompanyEmail);

            smtpClient.Send(newMail);

           
        }

    }
}