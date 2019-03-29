using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rad302Summer2019DataLayerdmulligan.DataModels
{
    public enum ResourceCategory
    {
        Music,
        Movie,
        AudioBook,
    }

    class OnlineResource
    {
        public int              ResourceID   { get; set; }
        public int              QuantitySold { get; set; }
        public string           Title        { get; set; }
        public decimal          UnitCost     { get; set; }
        public ResourceCategory ResourceType { get; set; }


    }
}
