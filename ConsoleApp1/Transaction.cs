using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	internal class Transaction
	{
		public double Amount { get; }
		public DateTime DateTime { get; }
		public string Note { get; }

        public Transaction(double amount, DateTime dateTime, string note)
        {
            Amount = amount;
			DateTime = dateTime;
			Note = note;
        }
    }
}
