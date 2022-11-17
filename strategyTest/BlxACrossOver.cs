using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strategyTest
{
    public class BlxACrossOver : CrossOver
    {
        //const double alpha = 0.08;
        const double alpha = 0.0791;
        public BlxACrossOver(double minX, double maxX)
        {
            MinX = minX;
            MaxX = maxX;
        }
        public override Individual[] Cross()
        {
            Random random1 = new Random(Guid.NewGuid().GetHashCode());
            Random random2 = new Random(Guid.NewGuid().GetHashCode());
            var child1 = new Individual(FitnessFunction, Size);
            var child2 = new Individual(FitnessFunction, Size);
            for (int i = 0; i < child1.Chromosome.Gens.Count; i++)
            {
                double param1 = (WorkParams1[i] + MaxX) / (MaxX - MinX);
                double param2 = (WorkParams2[i] + MaxX) / (MaxX - MinX);
                double Cmin = Math.Min(param1, param2);
                double Cmax = Math.Max(param1, param2);
                double delta = Cmax - Cmin;
                child1.Chromosome.Gens[i] = random1.NextDouble() * ((Cmax + alpha * delta) - (Cmin - alpha * delta)) + (Cmin - alpha * delta);
                child1.Chromosome.Gens[i] = child1.Chromosome.Gens[i] * (MaxX - MinX) - MaxX;
                child2.Chromosome.Gens[i] = random2.NextDouble() * ((Cmax + alpha * delta) - (Cmin - alpha * delta)) + (Cmin - alpha * delta);
                child2.Chromosome.Gens[i] = child2.Chromosome.Gens[i] * (MaxX - MinX) - MaxX;
            }
            child1.FitnessFunction.SetContext(child1);
            child1.Calc();
            child2.FitnessFunction.SetContext(child2);
            child2.Calc();
            Individual[] result = new Individual[2];
            result[0] = child1;
            result[1] = child2;
            return result;
        }
    }
}
