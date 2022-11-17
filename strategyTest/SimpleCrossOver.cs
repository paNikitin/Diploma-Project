using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strategyTest
{
    public class SimpleCrossOver : CrossOver
    {
        private static Random random = new Random(Guid.NewGuid().GetHashCode());
        
        public override Individual[] Cross()
        {
            int rand1 = random.Next(WorkParams1.Count);
            int rand2 = random.Next(WorkParams1.Count);
            int point1 = Math.Min(rand1, rand2);
            int point2 = Math.Max(rand1, rand2);
            var child1 = new Individual(FitnessFunction, Size);
            var child2 = new Individual(FitnessFunction, Size);
            for (int i = 0; i < point1; i++)
            {
                child1.Chromosome.Gens[i] = WorkParams1[i];
                child2.Chromosome.Gens[i] = WorkParams2[i];
            }
            for (int i = point1; i < point2; i++)
            {
                child1.Chromosome.Gens[i] = WorkParams2[i];
                child2.Chromosome.Gens[i] = WorkParams1[i];
            }
            for (int i = point2; i < WorkParams1.Count; i++)
            {
                child1.Chromosome.Gens[i] = WorkParams1[i];
                child2.Chromosome.Gens[i] = WorkParams2[i];
            }
            child1.FitnessFunction.SetContext(child1);
            child2.FitnessFunction.SetContext(child2);
            child1.Calc();
            child2.Calc();
            Individual[] result = new Individual[2];
            result[0] = child1;
            result[1] = child2;
            return result;
        }
    }
}
