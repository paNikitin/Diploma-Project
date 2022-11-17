using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strategyTest
{
    public class Individual
    {
        public FitnessFunction FitnessFunction { get; set; }
        public Individual(FitnessFunction fitnessFunction, int size, double min, double max)
        {
            Init(size, min, max);
            FitnessFunction = fitnessFunction;
            FitnessFunction.SetContext(this);
        }
        public Individual(FitnessFunction fitnessFunction,int size)
        {
            Init(size);
            FitnessFunction = fitnessFunction;
            FitnessFunction.SetContext(this);
        }
        public double FitnessValue { get; set; }
        public Chromosome Chromosome { get; set; }
        public void Calc() 
        {
            FitnessValue = FitnessFunction.Calc();
        }
        public void Init(int size, double min, double max)
        {
            Chromosome = new Chromosome(size, min, max);
        }
        public void Init(int size)
        {
            Chromosome = new Chromosome(size);
        }

    }
}
