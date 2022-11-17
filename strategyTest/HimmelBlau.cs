using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strategyTest
{
    public class HimmelBlau : FitnessFunction
    {
        public override double Calc()
        {
            double result = 0;
            double x = WorkParams[0];
            double y = WorkParams[1];
            result = (x * x + y - 11) * (x * x + y - 11) + (x + y * y - 7) * (x + y * y - 7);
            return result;
        }
    }
}
