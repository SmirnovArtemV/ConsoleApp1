using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	internal class CreditAccount : BankAccount
	{
		private double creditPercent = 0.25;

		public CreditAccount(string userName, double initialBalance)
			: base(userName, initialBalance)
		{
		}

		public override void MonthlyAction()
		{
			if (Balance < double.Epsilon)
			{
				MakeWithdrawal(-creditPercent * Balance, DateTime.Now, "Monthly Charge");
			}
		}
	}
}
