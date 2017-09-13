using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inheritance;

namespace TestInheritance {
	class Program {

		static void Main(string[] args) {
			new Program().Run();
		}

		void Run() {
			Account acct = new Account();
			acct.Number = 1;
			acct.Name = "Greg's Account";
			acct.Balance = 100.00;

			Console.WriteLine($"{acct.Number}:{acct.Name}-{acct.Balance}");

			Savings sav = new Savings();
			sav.IntRate = 0.05;
			sav.Number = 2;
			sav.Name = "Greg's Savings";
			sav.Balance = 200.00;

			Console.WriteLine($"{sav.Number}:{sav.Name}-{sav.Balance}:{sav.IntRate}");

			List<Account> myAccounts = new List<Account>();
			myAccounts.Add(acct);
			myAccounts.Add(sav);

			foreach (var account in myAccounts) {
				Console.WriteLine(account.ToPrint());
			}
			
		}
	}
}
