using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace Rad302Summer2019DataLayerdmulligan
{
    class DataContext : DbContext
    {
        public DataContext()
            : base("DefaultConnection")
        {
            Database.SetInitializer( new DatabaseInitialiser() );
            Database.Initialize(true);
        }
    }
}
