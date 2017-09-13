using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Account
    {
		public int Number;
		public string Name;
		public double Balance;

		//Because this method was marked as virtual, the ToPrint() in the Savings class is able to
		//use "overrride" to have the Savings version of ToPrint() called when the IntRate in that class
		//needs to be added.
		public virtual string ToPrint() {
			return $"{Number}:{Name}-{Balance}";
		}
    }
}
