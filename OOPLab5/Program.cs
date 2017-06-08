using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab5
{
	class Program
	{
		static void Main(string[] args)
		{
            Equation eq1 = new Equation(x => Math.Sin(x));
            Equation eq2 = new Equation(x => x * x + x);
            AlgebraEquation eq3 = new AlgebraEquation(new Vector());
            eq1.GetRootsCount(1, 3);
            eq2.GetRootsCount(2, 4);
            eq3.GetRootsCount(5, 6);
            var b = eq3.GetSturmRanges();

            SLAE s = new SLAE(new Matrix(10), new Vector(10));
            var meth = new Gauss(s);
            var res = meth.GetSolution();


        }
	}
}
