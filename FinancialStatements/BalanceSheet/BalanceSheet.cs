using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizWorks
{
    public class BalanceSheet 
    {
        private Date startDate;
        private Date endDate;
   
        //constructor
        public BalanceSheet(Date start, Date end)
        { 
            startDate = start;
            endDate = end
        }
