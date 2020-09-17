using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _301064861__UchieOkoro__Test1
{
    public class TransactionDetails
    {
        public string TransactionID { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public DateTime TransactionDate { get; set; }

        public TransactionDetails(string tid, string pname, decimal unitp, DateTime transDate)
        {
            this.TransactionID = tid;
            this.ProductName = pname;
            this.UnitPrice = unitp;
            this.TransactionDate = transDate;

        }
    }
}
