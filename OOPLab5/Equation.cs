using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab5
{
	class Equation
	{
		private Func<double, double> function;
		public Equation(Func<double, double> f) { }
		public Func<double, double> GetDerivative(int n) { throw new Exception(); }
		public int GetRootsCount(double a, double b) { return 0; }
	}
}
