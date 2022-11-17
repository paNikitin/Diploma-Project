using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace strategyTest
{
    public class Evolution
    {
        private int Generations { get; set; }
        private Recognition recognizer {get; set;}
        public void Run(int _populationCount, int _generations, int _layers, int _fitness)
        {
            Console.WriteLine("Начало обучения сети");
            Generations = _generations;
            Population population = new Population();
            population.PopulationCount = _populationCount;
            population.MinX = -5;
            population.MaxX = 5;
            if (_layers == 1)
            {
                population.FitnessFunction = new DigitRecognizeFitness();
                population.ChromosomeLength = 150;
            }
            else
            {
                population.FitnessFunction = new MultiLayerFitness();
                population.ChromosomeLength = 3450;
            }
            population.CreateInitialPopulation();
            for (int i = 0; i < Generations; i++)
            {
                Console.WriteLine(i+1);
                Selection selection = new TournamentSelection();
                selection.SetContext(population);
                population.SetIndividuals(selection.Screening());
                Mutation mutation = new SimpleMutation();
                mutation.SetContext(population);
                population.SetIndividuals(mutation.Mutate());
            }
            TrainingSet testSet = new TrainingSet();
            if (_layers == 1)
            {
                recognizer = new RecognizeDigit(population);
            }
            else
            {
                recognizer = new MultiLayerRecognition(population);
            }
            Console.WriteLine(recognizer.Recognize(testSet.nums[0]));
            Console.WriteLine(recognizer.Recognize(testSet.nums[1]));
            Console.WriteLine(recognizer.Recognize(testSet.nums[2]));
            Console.WriteLine(recognizer.Recognize(testSet.nums[3]));
            Console.WriteLine(recognizer.Recognize(testSet.nums[4]));
            Console.WriteLine(recognizer.Recognize(testSet.nums[5]));
            Console.WriteLine(recognizer.Recognize(testSet.nums[6]));
            Console.WriteLine(recognizer.Recognize(testSet.nums[7]));
            Console.WriteLine(recognizer.Recognize(testSet.nums[8]));
            Console.WriteLine(recognizer.Recognize(testSet.nums[9]));
            Console.WriteLine("Сеть обучена");
            WeightSaveForm popup = new WeightSaveForm();
            DialogResult dialogresult = popup.ShowDialog();
            if (dialogresult == DialogResult.OK)
            {
                List<Individual> dataList = new List<Individual>();
                dataList = population.GetIndividuals();
                XmlDocument memory_doc = new XmlDocument();
                memory_doc.Load(System.IO.Path.Combine("Resources", $"weights.xml"));
                XmlElement memory_el = memory_doc.DocumentElement;
                for (int l = 0; l < population.ChromosomeLength; ++l)
                {
                    memory_el.ChildNodes.Item(l).InnerText = dataList[0].Chromosome.Gens[l].ToString();
                }
                memory_doc.Save(System.IO.Path.Combine("Resources", $"weights.xml"));
            }
            else
            {
                popup.Dispose();
            }
            
        }
    }
}
