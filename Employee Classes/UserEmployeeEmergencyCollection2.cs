using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizWorks
{
    public class UserEmployeeEmergencyCollection2
    {
        private static List<EmergencyContact> EmployeeEmergencyContactList = new List<EmergencyContact>();

        public static void addUserEmergencyContact2(string Username, string eFirst,
            string eLast, string ePhoneNumber,
            string eRelation, DateTime createdOn,
            string createdBy, DateTime lastUpdatedOn, string lastUpdatedBy,
            string notes)
        {
            EmployeeEmergencyContactList.Add(new EmergencyContact(Username, eFirst,
                eLast, ePhoneNumber, eRelation, createdOn,
                createdBy, lastUpdatedOn, lastUpdatedBy, notes));
        }

        public static void ModifyUserEmergencyContact2(string passedUsername, string eFirst,
            string eLast, string ePhoneNumber,
            string eRelation, DateTime createdOn,
            string createdBy, DateTime lastUpdatedOn, string lastUpdatedBy,
            string notes)
        {
            foreach (var element in EmployeeEmergencyContactList
                .Where(element => element.Username == passedUsername))
            {
                element.FirstName = eFirst;
                element.LastName = eLast;
                element.PhoneNumber = ePhoneNumber;
                element.Relation = eRelation;
                element.UserCreatedOn = createdOn;
                element.UserCreatedBy = createdBy;
                element.UserLastUpdatedOn = lastUpdatedOn;
                element.UserLastUpdatedBy = lastUpdatedBy;
                element.UserNotes = notes;
            }
        }

        public static void RemoveEContact2(string username)
        {
            foreach (var element in EmployeeEmergencyContactList)
            {
                if (element.Username == username)
                {
                    EmployeeEmergencyContactList.Remove(element);
                }
            }
        }
        public static string GetFirstName2(string username)
        {
            string x = "";
            var query =
                from employee in EmployeeEmergencyContactList
                where employee.Username == username
                select employee.FirstName;
            foreach (var item in query)
            {
                x = item;
            }
            return x;
        }
        public static string GetLastName2(string username)
        {
            string x = "";
            var query =
                from employee in EmployeeEmergencyContactList
                where employee.Username == username
                select employee.LastName;
            foreach (var item in query)
            {
                x = item;
            }
            return x;
        }
        public static string GetPhone2(string username)
        {
            string x = "";
            var query =
                from employee in EmployeeEmergencyContactList
                where employee.Username == username
                select employee.PhoneNumber;
            foreach (var item in query)
            {
                x = item;
            }
            return x;
        }
        public static string GetRelation2(string username)
        {
            string x = "";
            var query =
                from employee in EmployeeEmergencyContactList
                where employee.Username == username
                select employee.Relation;
            foreach (var item in query)
            {
                x = item;
            }
            return x;
        }
        public static string GetNotes2(string username)
        {
            string x = "";
            var query =
                from employee in EmployeeEmergencyContactList
                where employee.Username == username
                select employee.UserNotes;
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
                from employee in EmployeeEmergencyContactList
                where employee.Username == username
                select employee.UserCreatedBy;
            foreach (var item in query) { x = item; }
            return x;
        }
        public static DateTime GetCreatedByDate(string username)
        {
            DateTime x = new DateTime();
            var query =
                from employee in EmployeeEmergencyContactList
                where employee.Username == username
                select employee.UserCreatedOn;
            foreach (var item in query) { x = item; }
            return x;
        }

    }
}
