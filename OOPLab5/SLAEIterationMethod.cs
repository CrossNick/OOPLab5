using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab5
{
    public abstract class SLAEIterationMethod
    {
        private Vector current;
        private SLAE system;
        public SLAEIterationMethod(SLAE system, Vector first) { }
        public abstract void NextIteration();
        public abstract double GetAccuracy();
        private Matrix GetBMatrix(SLAE system) { throw new Exception(); }
        private Vector GetGVector(SLAE system) { throw new Exception(); }
    }

    class Zeidel : SLAEIterationMethod
    {
        public Zeidel(SLAE syst, Vector f) : base(syst, f) { }
        public override double GetAccuracy() { throw new NotImplementedException(); }
        public override void NextIteration() { throw new NotImplementedException(); }
    }
    class SLAESimpleIterations : SLAEIterationMethod
    {
        public SLAESimpleIterations(SLAE syst, Vector f) : base(syst, f) { }
        public override double GetAccuracy() { throw new NotImplementedException(); }
        public override void NextIteration() { throw new NotImplementedException(); }
    }
}
