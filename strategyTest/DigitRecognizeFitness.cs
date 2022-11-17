using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strategyTest
{
    public class DigitRecognizeFitness : FitnessFunction
    {
        private TrainingSet trainingSet = new TrainingSet();

        public override double Calc()
        {
            Layer outputLayer = new Layer(10);
            for (int i = 0; i < 10; i++)
            { 
                outputLayer.Potential = 0;
                for (int j = 0; j < 15; j++)
                {
                    outputLayer.Potential += trainingSet.nums[i][j] * WorkParams[j+15*i];
                }
                outputLayer.ActivationFunction[i] = Math.Tanh(2 * outputLayer.Potential) + 1;
            }
            for (int i = 0; i < 10; i++)
            {
                outputLayer.NeuronOutputs[i] = outputLayer.ActivationFunction.Sum() / outputLayer.ActivationFunction[i];
            }
            return outputLayer.NeuronOutputs.Sum();
        }
    }
}