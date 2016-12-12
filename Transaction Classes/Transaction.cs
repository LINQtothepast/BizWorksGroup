using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizWorks
{
    public class Transaction : CreateUpdate
    {
        private int transactionID;
        private bool isCredit;       // if false, then debit company account. If true then credit company account transactionAmount $
        private string customerID;
        private double transactionAmount; // USD
        private string category;
        private DateTime transactionDate; //is this needed if u have a created date?
        private string assetID;        
     
        //use different names in the parameters than what is your private variables
        //constructor
        public Transaction(bool Credit, string custID, double transactAmount, string cgory,
        DateTime transactDate, string AssID, DateTime createdOn, string createdBy,
        DateTime lastUpdatedOn, string lastUpdatedBy, string notes)
            : base(createdOn, createdBy, lastUpdatedOn, lastUpdatedBy, notes)
        {
            IsCredit = Credit;
            CustomerID = custID;
            TransactionAmount = transactAmount;
            Category = cgory;
            TransactionDate = transactDate;
            AssetID = AssID;      // assetID == 1 is for cash, everything else is a material item eg. inventory
            transactionID = TransactionCollection.GetTransactionID();
        }

        public int TransactionID
        {
            get { return transactionID; }
            set { transactionID = value; }
        }
        public bool IsCredit
        {
            get { return isCredit; }
            set {isCredit = value; }
        }
        public string CustomerID
        {
            get { return customerID; }
            set { customerID = value; }
        }
        public string Category
        {
            get { return category; }
            set { category = value; }
        }
        
        public DateTime TransactionDate
        {
            get { return transactionDate; }
            set { transactionDate = value; }
        }
        
        public string AssetID
        {
            get {return assetID;}
            set {assetID = value;}
        }
        
        public double TransactionAmount
        {
            get { return transactionAmount; }
            set { transactionAmount = value; }
        }
    
    }
}
