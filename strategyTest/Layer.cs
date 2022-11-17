using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strategyTest
{
    public class Layer
    {
        public double[] ActivationFunction { get; set; }
        public double Potential { get; set; }
        public double[] NeuronOutputs { get; set; }

        public Layer(int neuronCount)
        {
            NeuronOutputs = new double[neuronCount];
            ActivationFunction = new double[neuronCount];
            Potential = new double();
        }
    }
}
