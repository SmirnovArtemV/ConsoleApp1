using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	public class BankAccount
	{
		private static int serialNumber = 1234567890;
		private List<Transaction> transactions = new List<Transaction>();

		public int Number { get; }
		public string UserName { get; }
		public double Balance 
		{ 
			get
			{
				var balance = 0.0;
				foreach (var transaction in transactions)
				{
					balance += transaction.Amount;
				}

				return balance;
			}
		}

        public BankAccount(string userName, double initialBalance)
        {
			if (initialBalance < double.Epsilon)
			{
				throw new ArgumentOutOfRangeException("balance must be positive");
			}

            UserName = userName;
			Number = serialNumber;
			serialNumber++;
			MakeDeposit(initialBalance, DateTime.Now, "Initial balance");
		}

        public void MakeDeposit(double amount, DateTime dateTime, string note)
		{
			var transaction = new Transaction(amount, dateTime, note);
			transactions.Add(transaction);
		}

		public void MakeWithdrawal(double amount, DateTime dateTime, string note)
		{
			var transaction = new Transaction(-amount, dateTime, note);
			transactions.Add(transaction);
		}

		public virtual void MonthlyAction()
		{
			//MakeDeposit(0.0001 * Balance, DateTime.Now, "Monthly Earning");
		}
	}
}
