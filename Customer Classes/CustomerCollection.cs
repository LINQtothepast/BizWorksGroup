using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizWorks
{
    public class CustomerCollection
    {
        private static List<Customer> CustomerList = new List<Customer>();

        public static void AddCustomer(int profileTypeID, string user, string pass,
            string workNum, string faxNum, string email, DateTime createdOn, string createdBy,
            DateTime lastUpdatedOn, string lastUpdatedBy, string notes)
        {
            CustomerList.Add(new Customer(profileTypeID,
                user, pass, workNum, faxNum, email, createdOn,
                createdBy, lastUpdatedOn, lastUpdatedBy, notes));
        }
    }

    }
}
