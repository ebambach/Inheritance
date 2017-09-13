using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance {
	public class Savings : Account {

		public double IntRate;

		//Thanks to "override," this ToPrint may be called instead of the "virtual" ToPrint in
		//Account, when it is relevant.
		public override string ToPrint() {
			return (base.ToPrint() + $"::{IntRate}");
		}
	}
}
