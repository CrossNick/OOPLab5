using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab5
{
	class AlgebraEquation : Equation
	{
		private Vector coeffs;
		public AlgebraEquation(Vector v) : base(null){}
		public Vector GetCoeffs() { throw new Exception(); }
		public new Func<double, double>  GetDerivative(int n) { throw new Exception(); }
		private static Vector GetRemainder(Vector f1, Vector f2) { throw new Exception(); }
		public double[,] GetSturmRanges() { throw new Exception(); }
	}
}
