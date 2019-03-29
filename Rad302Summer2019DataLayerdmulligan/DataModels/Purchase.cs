using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rad302Summer2019DataLayerdmulligan.DataModels
{
    class Purchase
    {
        public int      TransactionID     { get; set; }
        public int      CustomerID        { get; set; }
        public int      ResourceID        { get; set; }
        public DateTime DateOfPurchase    { get; set; }
        public int      QuantityPurchased { get; set; }


        public Purchase(int customerId, int resourceId, int quantity)
        {
            TransactionID     = Guid.NewGuid().GetHashCode();
            CustomerID        = customerId;
            ResourceID        = resourceId;
            DateOfPurchase    = DateTime.UtcNow;
            QuantityPurchased = quantity;
        }

        // a copy of all purchases will be stored here
        public static List<Purchase> History = new List<Purchase>();

        public static void MakePurchase(Purchase purchase) => History.Add(purchase);
    }
}
