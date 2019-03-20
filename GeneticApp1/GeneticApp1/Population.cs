using System;
using System.Collections.Generic;
using System.Text;

namespace GeneticApp1
{
    public class Population
    {

        int popSize = 10;
        public Individual[] individuals;
        public int fittest = 0;

        //Initialize population
        public void initializePopulation(int size)
        {
            for (int i = 0; i < individuals.Count; i++)
            {
                individuals[i] = new Individual();
            }
        }

        //Get the fittest individual
        public Individual getFittest()
        {
            int maxFit = int.MinValue;
            int maxFitIndex = 0;
            for (int i = 0; i < individuals.Count; i++)
            {
                if (maxFit <= individuals[i].fitness)
                {
                    maxFit = individuals[i].fitness;
                    maxFitIndex = i;
                }
            }
            fittest = individuals[maxFitIndex].fitness;
            return individuals[maxFitIndex];
        }

        //Get the second most fittest individual
        public Individual getSecondFittest()
        {
            int maxFit1 = 0;
            int maxFit2 = 0;
            for (int i = 0; i < individuals.Count; i++)
            {
                if (individuals[i].fitness > individuals[maxFit1].fitness)
                {
                    maxFit2 = maxFit1;
                    maxFit1 = i;
                }
                else if (individuals[i].fitness > individuals[maxFit2].fitness)
                {
                    maxFit2 = i;
                }
            }
            return individuals[maxFit2];
        }

        //Get index of least fittest individual
        public int getLeastFittestIndex()
        {
            int minFitVal = int.MaxValue;
            int minFitIndex = 0;
            for (int i = 0; i < individuals.Count; i++)
            {
                if (minFitVal >= individuals[i].fitness)
                {
                    minFitVal = individuals[i].fitness;
                    minFitIndex = i;
                }
            }
            return minFitIndex;
        }

        //Calculate fitness of each individual
        public void calculateFitness()
        {

            for (int i = 0; i < individuals.Count; i++)
            {
                individuals[i].calcFitness();
            }
            getFittest();
        }
    }
}
