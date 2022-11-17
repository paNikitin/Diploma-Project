using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strategyTest
{
    public class RouletteSelection : Selection
    {
        private static Random random = new Random(Guid.NewGuid().GetHashCode());
        private List<Individual> tempIndividuals = new List<Individual>();
        private List<Individual> resultIndividuals = new List<Individual>();
        public override List<Individual> Screening()
        {
            double average = 0;
            for(int i = 0; i < Individuals.Count; i++)
            {
                average += Individuals[i].FitnessValue;
            }
            average /= Individuals.Count;//максимизация
            for(int j = 0; j < Individuals.Count; j++)
            {
                if(Individuals[j].FitnessValue > average)
                {
                    for(int k = 0; k < Math.Truncate(Individuals[j].FitnessValue / average); k++)
                    {
                        tempIndividuals.Add(Individuals[j]);
                    }
                    double decision = random.NextDouble();
                    if(decision < (Individuals[j].FitnessValue / average - Math.Truncate(Individuals[j].FitnessValue / average)))
                    {
                        tempIndividuals.Add(Individuals[j]);
                    }
                }
                else
                {
                    double decision = random.NextDouble();
                    if (decision < (Individuals[j].FitnessValue / average))
                    {
                        tempIndividuals.Add(Individuals[j]);
                    }
                }
            }
            while(resultIndividuals.Count != PopulationCount)
            {
                int index1 = random.Next(tempIndividuals.Count);
                int index2 = random.Next(tempIndividuals.Count);
                if(tempIndividuals[index1].Chromosome.Gens == tempIndividuals[index2].Chromosome.Gens)
                {
                    while (tempIndividuals[index1].Chromosome.Gens == tempIndividuals[index2].Chromosome.Gens)
                    {
                        index2 = random.Next(tempIndividuals.Count);
                    }
                }
                CrossOver crossOver = new BlxACrossOver(MinX,MaxX);
                crossOver.SetContext(tempIndividuals[index1],tempIndividuals[index2]);
                Individual[] temp = new Individual[2];
                temp = crossOver.Cross();
                resultIndividuals.Add(temp[0]);
                resultIndividuals.Add(temp[1]);
            }
            Console.WriteLine(average);
            return resultIndividuals;
        }
    }
}
// турнирный отбор сгенерировано 1ое поколение, выполнить сортировку по возрастанию, выбираем 50%, ввыбираем по 4, с возможным повторением, скрещивание 2х лучших, пока не заполнится значение популяции
//рулетка поменять наоборот от среднего , переименовать в рулетку из турнира