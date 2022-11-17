using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strategyTest
{
    public abstract class Mutation
    {
        public List<Individual> Individuals { get; set; }
        public double MinX { get; set; }
        public double MaxX { get; set; }
        public int ChromosomeLength { get; set; }
        public void SetContext(Population population)
        {
            Individuals = population.GetIndividuals().ToList();
            MinX = population.MinX;
            MaxX = population.MaxX;
            ChromosomeLength = population.ChromosomeLength;
        }
        public abstract List<Individual> Mutate();
    }
}
