using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strategyTest
{
    public class TournamentSelection : Selection
    {
        private static Random random = new Random(Guid.NewGuid().GetHashCode());
        private List<Individual> resultIndividuals = new List<Individual>();
        private Individual parent1 { get; set; }
        private Individual parent2 { get; set; }
        public override List<Individual> Screening()
        {
            Individuals.Sort(delegate (Individual obj1, Individual obj2)
            { return obj1.FitnessValue.CompareTo(obj2.FitnessValue); });

            Console.WriteLine(Individuals[0].FitnessValue.ToString() + "   " + Individuals[PopulationCount / 2].FitnessValue.ToString() + "   " + Individuals[PopulationCount - 1].FitnessValue.ToString());

            Individuals.RemoveRange(PopulationCount / 2, PopulationCount / 2);
            while (resultIndividuals.Count != PopulationCount)
            {

                List<int> indexList = new List<int>();
                for (int i = 0; i < 4; i++)
                {
                    indexList.Add(random.Next(PopulationCount / 2));
                }
                if (Individuals[indexList[0]].FitnessValue < Individuals[indexList[1]].FitnessValue)
                {
                    parent1 = Individuals[indexList[0]];
                }
                else
                {
                    parent1 = Individuals[indexList[1]];
                }
                if (Individuals[indexList[2]].FitnessValue < Individuals[indexList[3]].FitnessValue)
                {
                    parent2 = Individuals[indexList[2]];
                }
                else
                {
                    parent2 = Individuals[indexList[3]];
                }
                CrossOver crossOver = new BlxACrossOver(MinX, MaxX);
                crossOver.SetContext(parent1, parent2);
                Individual[] temp = new Individual[2];
                temp = crossOver.Cross();
                resultIndividuals.Add(temp[0]);
                resultIndividuals.Add(temp[1]);
            }
            return resultIndividuals;
        }
    }
}
