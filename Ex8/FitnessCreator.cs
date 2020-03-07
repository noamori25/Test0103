using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test010320.Ex8
{
   public class FitnessCreator
    {
       private IFitnessTrainingBuilder fitness;

        public FitnessCreator(IFitnessTrainingBuilder fitness)
        {
            this.fitness = fitness;
        }
        public void CreateFitness()
        {
            fitness.PreWorkout();
            fitness.Cardio();
            fitness.WeightTraining();
            fitness.EndOfPractice();
        }
        public FitnessTraining GetFitnessTraining()
        {
            return fitness.GetFitness();
        }
    }
}
