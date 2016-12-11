using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizWorks
{
    public class BalanceSheet 
    {
        private DateTime startDate;
        private DateTime endDate;
        private float assets;
        private float debts;
   
        //constructor
        public BalanceSheet(DateTime start, DateTime end)
        { 
            startDate = start;
            endDate = end;
            
            List<Transaction> trans = TransactionCollection.TransactionList;
            
            for(int i=0; i < trans.Count; i++)
            {
                if(trans[i].TransactionDate > start && trans[i].TransactionDate < end)
                {
                    if(trans[i].isCredit == true)
                    {
                        assets += trans[i].TransactionAmount;
                    }
                    else
                    {
                        debts += trans[i].TransactionAmount;
                    }
                }
            }
        }
        
                        
             
        }
