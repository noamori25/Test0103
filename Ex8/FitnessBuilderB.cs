using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test010320.Ex8
{
   public class FitnessBuilderB :IFitnessTrainingBuilder
    {
        FitnessTraining fitness = new FitnessTraining();

        public void Cardio()
        {
            fitness.Cardio = "im B";
        }

        public void EndOfPractice()
        {
            fitness.EndOfPractice = "im B";
        }

        public FitnessTraining GetFitness()
        {
            return fitness;
        }

        public void PreWorkout()
        {
            fitness.PreWorkout = "im B";
        }

        public void WeightTraining()
        {
            fitness.WeightTraining = "im B";
        }
    }
}
