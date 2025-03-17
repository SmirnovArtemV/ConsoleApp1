using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	internal class DebetAccount : BankAccount
	{
        private double debetPercent = 0.02;

        public DebetAccount(string userName, double initialBalance) 
            : base(userName, initialBalance)
        {
        }

		public override void MonthlyAction()
		{
			MakeDeposit(debetPercent * Balance, DateTime.Now, "Monthly Earning");
			//base.MonthlyAction();
		}
	}
}
