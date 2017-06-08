using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab5
{
	class EquationSolution
	{
		public Equation eq;
		public enum Iteration_Method { SimpleIterations, Newton, Chords}
		public EquationSolution(Equation eq) { }
		public double HalfDevision(double x0, double a, double b, double eps) { return 0.0; }
		public double IterativeSolution(Iteration_Method m, double x0, double a, double b, double eps) { return 0.0; }

    }
    
}
