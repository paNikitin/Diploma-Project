using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strategyTest
{
    public class MultiLayerFitness : FitnessFunction
    {
        private MultiLayerTrainingSet trainingSet = new MultiLayerTrainingSet();
        public override double Calc()
        {
            //1ый скрытый слой
            Layer firstHiddenLayer = new Layer(70);
            for (int i = 0; i < 70; i++)
            {
                firstHiddenLayer.Potential = 0;
                for (int j = 0; j < 15; j++)
                {
                    firstHiddenLayer.Potential += trainingSet.nums[i][j] * WorkParams[j + 15 * i];
                }
                //firstHiddenLayer.ActivationFunction[i] = Math.Tanh(2 * firstHiddenLayer.Potential) + 1;
                if (firstHiddenLayer.Potential < 0)
                {
                    firstHiddenLayer.ActivationFunction[i] = 0.01 * firstHiddenLayer.Potential;
                }
                else
                {
                    firstHiddenLayer.ActivationFunction[i] = firstHiddenLayer.Potential;
                }
            }
            for (int i = 0; i < 70; i++)
            {
                firstHiddenLayer.NeuronOutputs[i] = firstHiddenLayer.ActivationFunction.Sum() / firstHiddenLayer.ActivationFunction[i];
            }

            //2ой скрытый слой
            Layer secondHiddenLayer = new Layer(30);
            for (int i = 0; i < 30; i++)
            {
                secondHiddenLayer.Potential = 0;
                for (int j = 0; j < 70; j++)
                {
                    secondHiddenLayer.Potential += firstHiddenLayer.NeuronOutputs[j] * WorkParams[j + 70 * i + 1050];
                }
                //secondHiddenLayer.ActivationFunction[i] = Math.Tanh(2 * secondHiddenLayer.Potential) + 1;
                if (secondHiddenLayer.Potential < 0)
                {
                    secondHiddenLayer.ActivationFunction[i] = 0.01 * secondHiddenLayer.Potential;
                }
                else
                {
                    secondHiddenLayer.ActivationFunction[i] = secondHiddenLayer.Potential;
                }
            }
            for (int i = 0; i < 30; i++)
            {
                secondHiddenLayer.NeuronOutputs[i] = secondHiddenLayer.ActivationFunction.Sum() / secondHiddenLayer.ActivationFunction[i];
            }

            //выходной слой
            Layer outputLayer = new Layer(10);
            for (int i = 0; i < 10; i++)
            {
                outputLayer.Potential = 0;
                for (int j = 0; j < 30; j++)
                {
                    outputLayer.Potential += secondHiddenLayer.NeuronOutputs[j] * WorkParams[j + 30 * i + 2100];
                }
                //outputLayer.ActivationFunction[i] = Math.Tanh(2 * outputLayer.Potential) + 1;
                outputLayer.ActivationFunction[i] = Math.Exp(outputLayer.Potential);
            }
            for (int i = 0; i < 10; i++)
            {
                outputLayer.NeuronOutputs[i] = outputLayer.ActivationFunction.Sum() / outputLayer.ActivationFunction[i];
            }
            return outputLayer.NeuronOutputs.Sum();
        }
    }
}
//1ый скрытый) 70 нейронов с 15 входами
//2ой скрытый) 30 нейронов с 70 входами
//выходной) 10 нейронов с 30 входами
//3450 длина

//1ый слой) 15 15 15 15 15 15 15 15 15 15 15 15 15 ...... по столько брать из хромосомы
//2ой слой) 70 70 70 70 70 70 70 70 70 70 70 ...... по столько брать из хромосомы
//3ий слой) 30 30 30 30 30 30 30 30 30 30 по столько брать из хромосомы