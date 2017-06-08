using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab5
{
    abstract class SLAEMethod
    {
        private SLAE system;
        public SLAEMethod(SLAE syst) { }
        public abstract Vector GetSolution();
    }
    class Gauss : SLAEMethod
    {
        public Gauss(SLAE syst) : base(syst) { }
        public override Vector GetSolution()
        {
            throw new NotImplementedException();
        }

    }
    class LUMethod : SLAEMethod
    {
        public LUMethod(SLAE syst) : base(syst) { }
        public override Vector GetSolution()
        {
            throw new NotImplementedException();
        }
    }
    class Squares : SLAEMethod
    {
        public Squares(SLAE syst) : base(syst) { }
        public override Vector GetSolution()
        {
            throw new NotImplementedException();
        }
    }
}
