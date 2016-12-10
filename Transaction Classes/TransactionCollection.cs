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
        DateTime transactDate, int AssID, DateTime createdOn, string createdBy, DateTime lastUpdatedOn,
            string lastUpdatedBy, string notes)
        {
            TransactionList.Add(new Transaction(Credit, custID, transactAmount, cgory, transactDate,
                AssID, createdOn, createdBy, lastUpdatedOn, lastUpdatedBy, notes));
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