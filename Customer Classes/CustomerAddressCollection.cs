using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizWorks
{
    public class CustomerAddressCollection
    {
        private static List<Address> CustomerAddressList = new List<Address>();

        public static void addCustomerAddress(string profileName, string addressStreet,
            string addressCity, string addressState,
            int addressZipCode, DateTime createdOn,
            string createdBy, DateTime lastUpdatedOn, string lastUpdatedBy,
            string notes)
        {
            CustomerAddressList.Add(new Address(profileName, addressStreet,
                addressCity, addressState, addressZipCode, createdOn,
                createdBy, lastUpdatedOn, lastUpdatedBy, notes));
        }

        public static void ModifyCustomerAddress1(string profileName, string addressStreet,
            string addressCity, string addressState,
            int addressZipCode, DateTime createdOn,
            string createdBy, DateTime lastUpdatedOn, string lastUpdatedBy,
            string notes, int guiID)
        {
            foreach (var element in CustomerAddressList
                .Where(element => element.UserProfileName == profileName))
            {
                element.UserAddressStreet = addressStreet;
                element.UserAddressCity = addressCity;
                element.UserAddressState = addressState;
                element.UserAddressZipCode = addressZipCode;
                element.UserCreatedOn = createdOn;
                element.UserCreatedBy = createdBy;
                element.UserLastUpdatedOn = lastUpdatedOn;
                element.UserLastUpdatedBy = lastUpdatedBy;
                element.UserNotes = notes;
            }
        }

        public static string GetStreet1(string passedUsername)
        {
            string x = "";
            var query =
                from customer in CustomerAddressList
                where customer.UserProfileName == passedUsername
                select customer.UserAddressStreet;
            foreach (var item in query)
            {
                x = item;
            }
            return x;
        }
        public static string GetCity1(string passedUsername)
        {
            string x = "";
            var query =
                from customer in CustomerAddressList
                where customer.UserProfileName == passedUsername
                select customer.UserAddressCity;
            foreach (var item in query)
            {
                x = item;
            }
            return x;
        }
        public static string GetState1(string passedUsername)
        {
            string x = "";
            var query =
                from customer in CustomerAddressList
                where customer.UserProfileName == passedUsername
                select customer.UserAddressState;
            foreach (var item in query)
            {
                x = item;            }
            return x;
        }
        public static int GetZipCode1(string passedUsername)
        {
            int x = 0;
            var query =
                from customer in CustomerAddressList
                where customer.UserProfileName == passedUsername
                select customer.UserAddressZipCode;
            foreach (var item in query)
            {
                x = item;            }
            return x;
        }
        public static string GetNotes1(string passedUsername)
        {
            string x = "";
            var query =
                from customer in CustomerAddressList
                where customer.UserProfileName == passedUsername
                select customer.UserNotes;
            foreach (var item in query)
            {
                x = item;
            }
            return x;
        }

        public static string GetCreatedBy(string username)
        {
            string x = "";
            var query =
                from customer in CustomerAddressList
                where customer.UserProfileName == username
                select customer.UserCreatedBy;
            foreach (var item in query) { x = item; }
            return x;
        }
        public static DateTime GetCreatedByDate(string username)
        {
            DateTime x = new DateTime();
            var query =
                from customer in CustomerAddressList
                where customer.UserProfileName == username
                select customer.UserCreatedOn;
            foreach (var item in query) { x = item; }
            return x;
        }

    }
}
