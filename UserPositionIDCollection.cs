using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizWorks
{
	public class UserPositionIDCollection
	{
		private static List<UserPositionID> UserPositionIDList = new List<UserPositionID>();
		
		public static void addUserPositionID(int userId, string userPosition, double userPay)
        {
            UserPositionIDList.Add(new UserPositionID(userId, userPosition, userPay));
        }

        public static List<UserPositionID> ReturnAList()
        {
            return UserPositionIDList;
        }

        public static double GetPay(string passedPositionName)
        {
            double x = 0;
            var query =
                from element in UserPositionIDList
                where element.UserPosition == passedPositionName
                select element.UserPay;
            foreach (var item in query) { x = item; }
            return x;
        }
        public static int GetID(string passedPositionName)
        {
            int x = 0;
            var query =
                from element in UserPositionIDList
                where element.UserPosition == passedPositionName
                select element.UserId;
            foreach (var item in query) { x = item; }
            return x;
        }
    }
}