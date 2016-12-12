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
	}
}