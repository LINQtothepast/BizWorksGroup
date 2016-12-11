using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizWorks
{
    public class TransactionCollection
    {
        private static List<Transaction> TransactionList = new List<Transaction>();

        private static void AddTransaction(bool Credit, int custID, float transactAmount, string cgory,
        DateTime transactDate, int AssID, DateTime createdOn, string createdBy, string notes)
        {
            TransactionList.Add(new Transaction(Credit, custID, transactAmount, cgory, transactDate,
                AssID, createdOn, createdBy, notes));
        }
        
         
        public static String listTransactions(DateTime transDate){
            for (int i = 0; i <= TransactionList.Count(); i++)
            {
                if (TransactionList[i].transactionDate == transDate){
                    Console.WriteLine("Amount : ", TransactionList[i].transactionAmount);
                    Console.WriteLine("Customer : ", getCustomerName(TransactionList[i].CustomerID));
                    Console.WriteLine("Date : ", TransactionList[i].transactionDate);
                   }
            }
        }

        private static int GetTransactionID()
        {
            //put what you need here
            int x = TransactionList.Count();
            //would give u x as 3 if array [0], [1], and [2] are filled
            //which would be where TransactionList.Add will add onto but
            //you will need to run checks to make sure
            return x;
        }
    }
}
