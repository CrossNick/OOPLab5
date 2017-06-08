using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab5
{
    public abstract class IterationMethod
    {
        double current;
        Equation eq;
        double a;
        double b;
        public IterationMethod(Equation eq, double a, double b) { }
        public void NextIteraion() { }
        public double GetAccuracy() { return 0.0; }
        public abstract Func<double, double> GetPsi();
    }

    class SimpleIterations : IterationMethod
    {
        public SimpleIterations(Equation eq, double _a, double _b) : base(eq, _a, _b) { }
        public override Func<double, double> GetPsi() { throw new NotImplementedException(); }
    }
    class Newton : IterationMethod
    {
        public Newton(Equation eq, double _a, double _b) : base(eq, _a, _b) { }
        public override Func<double, double> GetPsi() { throw new NotImplementedException(); }
    }
    class Chords : IterationMethod
    {
        public Chords(Equation eq, double _a, double _b) : base(eq, _a, _b) { }
        public override Func<double, double> GetPsi() { throw new NotImplementedException(); }
    }
}
