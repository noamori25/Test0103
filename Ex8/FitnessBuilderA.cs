using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test010320.Ex8
{
    public class FitnessBuilderA : IFitnessTrainingBuilder
    {
        FitnessTraining fitness = new FitnessTraining();

        public void Cardio()
        {
            fitness.Cardio = "im A";
        }

        public void EndOfPractice()
        {
            fitness.EndOfPractice = "im A";
        }

        public FitnessTraining GetFitness()
        {
            return fitness;
        }

        public void PreWorkout()
        {
            fitness.PreWorkout = "im A";
        }

        public void WeightTraining()
        {
            fitness.WeightTraining = "im A";
        }
    }
}
