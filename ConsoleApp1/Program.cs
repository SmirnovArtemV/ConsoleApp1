using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var accounts = new List<BankAccount>();

			var creditAccount = new CreditAccount("myCreditAccount", 500);
			creditAccount.MakeDeposit(20, DateTime.Now, "Cash back");
			creditAccount.MakeWithdrawal(1000, DateTime.Now, "Repair phone");

			Console.WriteLine($"Credit account: {creditAccount.Balance}");

			var debetAccount = new DebetAccount("myDebetAccount", 500);
			debetAccount.MakeWithdrawal(20, DateTime.Now, "Lunch");

			Console.WriteLine($"Debet account: {debetAccount.Balance}");

			accounts.Add(creditAccount);
			accounts.Add(debetAccount);

			foreach (var account in accounts)
			{
				account.MonthlyAction();
			}

			Console.WriteLine($"Credit account: {creditAccount.Balance}");
			Console.WriteLine($"Debet account: {debetAccount.Balance}");

			Console.ReadKey();
		}
	}
}
