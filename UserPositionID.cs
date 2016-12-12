using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizWorks
{
	public class UserPositionID 
	{
		private int userId;
		private string userPosition;
		private double userPay;
		
		//constructor
		public UserPositionID(int Id, string Position, double Pay)
		{
			UserId = Id;
			UserPosition = Position;
			UserPay = Pay;
		}
		
        //properties
		public int UserId
		{
			get { return userId; }
			set { userId = value; }
		}
		
		public string UserPosition
		{
			get { return userPosition; }
			set { userPosition = value; }
		}
		
		public double UserPay
		{
			get { return userPay; }
			set { userPay = value; }
		}
	}
}