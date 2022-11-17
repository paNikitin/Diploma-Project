using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strategyTest
{
    public class Chromosome
    {
        private static Random random = new Random(Guid.NewGuid().GetHashCode());
        public  List<double> Gens = new List<double>();
        public void Init(int size) 
        {
            for (int j = 0; j < size; j++)
            {
                Gens.Add(0);
            }
        }
        public void Init(int size,double min, double max)
        {
            for (int j = 0; j < size; j++)
            {
                Gens.Add(random.NextDouble() * (max-min)-max);
            }
        }
        public Chromosome(int size)
        {
            Init(size);
        }
        public Chromosome(int size, double min, double max)
        {
            Init(size,min,max);
        }
    }
}
