using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strategyTest
{
    public abstract class Selection
    {
        public List<Individual> Individuals { get; set; }
        public int PopulationCount { get; set; }
        public double MinX { get; set; }
        public double MaxX { get; set; }

        public void SetContext(Population population)
        {
            Individuals = population.GetIndividuals().ToList();
            PopulationCount = population.PopulationCount;
            MinX = population.MinX;
            MaxX = population.MaxX;
        }
        public abstract List<Individual> Screening();
    }
}
