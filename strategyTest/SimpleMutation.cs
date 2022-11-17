using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strategyTest
{
    public class SimpleMutation : Mutation
    {
        private static Random random = new Random(Guid.NewGuid().GetHashCode());
        public override List<Individual> Mutate()
        {
            int NumberToMutate = Individuals.Count * 5 / 100;
            for (int j = 0; j < NumberToMutate; j++)
            {
                int indexOfIndividual = random.Next(Individuals.Count);
                int indexOfGen = random.Next(ChromosomeLength);
                Individuals[indexOfIndividual].Chromosome.Gens[indexOfGen] = random.NextDouble() * (MaxX - MinX) - MaxX;
                Individuals[indexOfIndividual].FitnessFunction.SetContext(Individuals[indexOfIndividual]);
                Individuals[indexOfIndividual].Calc();
            }
            Individuals.Sort(delegate (Individual obj1, Individual obj2)
            { return obj1.FitnessValue.CompareTo(obj2.FitnessValue); });
            return Individuals;
        }
    }
}
