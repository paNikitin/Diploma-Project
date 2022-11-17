using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strategyTest
{
    public class RecognizeDigit : Recognition
    {
        public RecognizeDigit(Population population)
        {
            Individuals = population.GetIndividuals();
            Chromosome = Individuals[0].Chromosome.Gens;
        }
        public override int Recognize(int[] number)
        {
            Layer outputLayer = new Layer(10);
            for (int i = 0; i < 10; i++)
            {
                outputLayer.Potential = 0;
                for (int j = 0; j < 15; j++)
                {
                    outputLayer.Potential += number[j] * Chromosome[j + 15 * i];
                }
                outputLayer.ActivationFunction[i] = Math.Tanh(2 * outputLayer.Potential) + 1;
            }
            double max = 0;
            for (int i = 0; i < 10; i++)
            {
                if (outputLayer.ActivationFunction[i] > max)
                {
                    max = outputLayer.ActivationFunction[i];
                    indexOfDigit = i;
                }
            }  
            return indexOfDigit;
        }
    }
}
