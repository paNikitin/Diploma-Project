using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strategyTest
{
    public abstract class Recognition
    {
        protected int indexOfDigit = 0;
        protected List<Individual> Individuals { get; set; }
        protected List<double> Chromosome { get; set; }
        public abstract int Recognize(int[] number);
    }
}
