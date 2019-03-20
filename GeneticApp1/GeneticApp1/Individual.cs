using System;
using System.Collections.Generic;
using System.Text;

namespace GeneticApp1
{
    public class Individual
    {
        public int fitness = 0;
        public List<int> genes = new List<int>();
        public int geneLength = 5;

        public Individual()
        {
            Random rn = new Random();

            //Set genes randomly for each individual
            for (int i = 0; i < genes.Count; i++)
            {
                genes[i] = Math.Abs(rn.Next() % 2);
            }

            fitness = 0;
        }

        //Calculate fitness
        public void calcFitness()
        {

            fitness = 0;
            for (int i = 0; i < 5; i++)
            {
                if (genes[i] == 1)
                {
                    ++fitness;
                }
            }
        }
    }
}
