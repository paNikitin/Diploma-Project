using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strategyTest
{
    public class Sphere : FitnessFunction
    {
        public override double Calc()
        {
            double result = 0;
            for (int i = 0; i < WorkParams.Count; i++)
            {
                 result += WorkParams[i] * WorkParams[i];
            }
            return result; 
        }
       
    }
}
