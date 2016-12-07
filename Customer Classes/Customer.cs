using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizWorks
{
    class Customer : UserInfo
    {

        //Attributes

        //Constructor
        public Customer(int profileTypeID, string user, string pass,
            string workNum, string faxNum, string email, DateTime createdOn, string createdBy,
            DateTime lastUpdatedOn, string lastUpdatedBy, string notes)
            : base (profileTypeID, user, pass, workNum, faxNum, email,
                    createdOn, createdBy, lastUpdatedOn, lastUpdatedBy,
                    notes)
        {

        }

        //Properties
        
        
    }
}
