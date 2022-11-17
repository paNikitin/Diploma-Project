using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strategyTest
{
    public class Population
    {
        private static Random Random = new Random(Guid.NewGuid().GetHashCode());
        private static List<Individual> Individuals = new List<Individual>();
        public FitnessFunction FitnessFunction { get; set; }
        public int PopulationCount { get; set; }
        public int ChromosomeLength { get; set; }
        public double MinX { get; set; }
        public double MaxX { get; set; }
        public List<Individual> GetIndividuals()
        {
            return Individuals;
        }
        public void SetIndividuals(List<Individual> individuals)
        {
            Individuals.Clear();
            Individuals = individuals;
        }
        public void CreateInitialPopulation()
        {
            for (int i = 0; i < PopulationCount; i++)
            {
                var individual = new Individual(FitnessFunction,ChromosomeLength,MinX,MaxX);
                individual.Calc();
                Individuals.Add(individual);
            }
        }
    }
}

