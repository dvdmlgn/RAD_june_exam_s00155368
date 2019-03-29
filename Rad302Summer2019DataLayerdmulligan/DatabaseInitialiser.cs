using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rad302Summer2019DataLayerdmulligan
{
    class DatabaseInitialiser : DropCreateDatabaseIfModelChanges<DataContext>
    {
        public DatabaseInitialiser() { }

        protected override void Seed(DataContext context)
        {
            SeedUsers();
            SeedCustomers();
            SeedOnlineResources();
            SeedPruchases();
            SeedTopups();

            base.Seed(context);
        }



        private static void SeedUsers()
        {

        }

        private static void SeedCustomers()
        {

        }

        private static void SeedOnlineResources()
        {

        }

        private static void SeedPruchases()
        {

        }

        private static void SeedTopups()
        {

        }


    }
}
