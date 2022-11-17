using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strategyTest
{
    public abstract class CrossOver
    {
        public List<double> WorkParams1 { get; set; }
        public List<double> WorkParams2 { get; set; }
        public FitnessFunction FitnessFunction { get; set; }
        public int Size { get; set; }
        public double MinX { get; set; }
        public double MaxX { get; set; }
        public void SetContext(Individual parent1, Individual parent2)
        {
            WorkParams1 = parent1.Chromosome.Gens;
            WorkParams2 = parent2.Chromosome.Gens;
            FitnessFunction = parent1.FitnessFunction;
            Size = parent1.Chromosome.Gens.Count;
        }
        public abstract Individual[] Cross();
    }
}
