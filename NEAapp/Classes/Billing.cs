using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEAapp.Classes
{
    class Billing
    {

        List<string> PaidInvoices = new List<string>();
        List<string> UnpaidInvoices = new List<string>();
        DateTime nextBillingDate;
        DateTime lastBillPaid;
        List<int> invoiceNumbers; //Corrosponds to SQL stored place
        string BillingInformation;

        public Billing(string Billinginfo)
        {
            this.BillingInformation = Billinginfo;
        }

        public DateTime getLastBillingDate()
        {
            if (this.lastBillPaid != null)
            {
                return this.lastBillPaid;
            }
            else
                return DateTime.Now;
        } 

        public DateTime getNextBillingDate()
        {
            if (this.nextBillingDate != null)
            {
                return this.nextBillingDate;
            }
            else
                return DateTime.Now;
        }

        public string getBillingInfo()
        {
            return this.BillingInformation;
        }

        public void updatebillinginfo(string newInfo)
        {
            this.BillingInformation = newInfo;
        }

    }
}
