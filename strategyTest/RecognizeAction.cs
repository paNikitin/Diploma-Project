using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace strategyTest
{
    public class RecognizeAction
    {
        public int Action(int[] number)
        {
            Population population = new Population();
            population.PopulationCount = 10000;
            population.ChromosomeLength = 150;
            population.FitnessFunction = new DigitRecognizeFitness();
            XmlDocument memory_doc = new XmlDocument();
            memory_doc.Load(System.IO.Path.Combine("Resources", $"weights.xml"));
            XmlElement memory_el = memory_doc.DocumentElement;
            Individual tempIndividual = new Individual(population.FitnessFunction, population.ChromosomeLength);
            for (int l = 0; l < population.ChromosomeLength; ++l)
            {
                tempIndividual.Chromosome.Gens[l] = double.Parse(memory_el.ChildNodes.Item(l).InnerText.Replace(',', '.'), System.Globalization.CultureInfo.InvariantCulture);//parsing stuff
            }
            List<Individual> dataList = new List<Individual>();
            dataList.Add(tempIndividual);
            population.SetIndividuals(dataList);
            RecognizeDigit recognizer = new RecognizeDigit(population);
            return recognizer.Recognize(number);
        }
    }
}
