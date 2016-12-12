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

        public static void AddCustomer(string name, int profileTypeID, string user, string pass,
            string workNum, string faxNum, string email, DateTime createdOn, string createdBy,
            DateTime lastUpdatedOn, string lastUpdatedBy, string notes)
        {
            CustomerList.Add(new Customer(name, profileTypeID,
                user, pass, workNum, faxNum, email, createdOn,
                createdBy, lastUpdatedOn, lastUpdatedBy, notes));
        }

        public static void ModifyCustomer(string name, int profileTypeID, string user, string pass,
            string workNum, string faxNum, string email, DateTime createdOn, string createdBy,
            DateTime lastUpdatedOn, string lastUpdatedBy, string notes)
        {
            foreach (var element in CustomerList
                .Where(element => element.CompanyName == name))
            {
                element.Username = user;
                element.WorkNumber = workNum;
                element.FaxNumber = faxNum;
                element.Email = email;
                element.UserCreatedOn = createdOn;
                element.UserCreatedBy = createdBy;
                element.UserLastUpdatedOn = lastUpdatedOn;
                element.UserLastUpdatedBy = lastUpdatedBy;
                element.UserNotes = notes;
            }
        }

        public static List<Customer> ReturnAList()
        {
            List<Customer> theList = new List<Customer>();
            theList = CustomerList;

            return theList;
        }
        public static string GetCompanyName(string username)
        {
            string x = "";
            var query =
                from customer in CustomerList
                where customer.Username == username
                select customer.CompanyName;
            foreach (var item in query) { x = item; }
            return x;
        }
        public static int GetProfileType(string username)
        {
            int x = 0;
            var query =
                from customer in CustomerList
                where customer.Username == username
                select customer.UserProfileTypeID;
            foreach (var item in query) { x = item; }
            return x;
        }
        public static string GetWorkPhone(string username)
        {
            string x = "";
            var query =
                from customer in CustomerList
                where customer.Username == username
                select customer.WorkNumber;
            foreach (var item in query) { x = item; }
            return x;
        }
        public static string GetFaxNumber(string username)
        {
            string x = "";
            var query =
                from customer in CustomerList
                where customer.Username == username
                select customer.FaxNumber;
            foreach (var item in query) { x = item; }
            return x;
        }
        public static string GetEmail(string username)
        {
            string x = "";
            var query =
                from customer in CustomerList
                where customer.Username == username
                select customer.Email;
            foreach (var item in query) { x = item; }
            return x;
        }
        public static string GetNotes(string username)
        {
            string x = "";
            var query =
                from customer in CustomerList
                where customer.Username == username
                select customer.UserNotes;
            foreach (var item in query) { x = item; }
            return x;
        }
        public static string GetPassword(string username)
        {
            string x = "";
            var query =
                from customer in CustomerList
                where customer.Username == username
                select customer.Password;
            foreach (var item in query) { x = item; }
            return x;
        }
        public static string GetCreatedBy(string username)
        {
            string x = "";
            var query =
                from customer in CustomerList
                where customer.Username == username
                select customer.UserCreatedBy;
            foreach (var item in query) { x = item; }
            return x;
        }
        public static DateTime GetCreatedByDate(string username)
        {
            DateTime x = new DateTime();
            var query =
                from customer in CustomerList
                where customer.Username == username
                select customer.UserCreatedOn;
            foreach (var item in query) { x = item; }
            return x;
        }
    }

}
