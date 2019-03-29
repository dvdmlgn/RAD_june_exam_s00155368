using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rad302Summer2019DataLayerdmulligan.DataModels
{
    public class Customer
    {
        public int      CustomerID           { get; set; }
        public string   CustomerName         { get; set; }
        public DateTime RegisteredOn         { get; set; }
        public decimal  CurrentCreditBalance { get; set; }


        public void TopupAccount(decimal amount)
        {
            var topup = new Topup(CustomerID, amount);

            Topup.MakeTransaction(topup);
        }

    }
}
