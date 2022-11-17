using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strategyTest
{
    public abstract class FitnessFunction
    {
        public List<double> WorkParams { get; set; }
        public void SetContext(Individual individual)
        {
            WorkParams = individual.Chromosome.Gens;
        }
        public abstract double Calc();
    }
}
