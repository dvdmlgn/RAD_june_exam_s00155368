using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rad302Summer2019DataLayerdmulligan.DataModels
{
    class Topup
    {
        public int      TransactionID { get; set; }
        public int      CustomerID    { get; set; }
        public DateTime Date          { get; set; }
        public decimal  Amount        { get; set; }

        // a copy of all transactions will be stored here
        public static List<Topup> History = new List<Topup>();

        public static void MakeTransaction(Topup topup) => History.Add(topup);

    }
}
