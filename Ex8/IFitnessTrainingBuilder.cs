using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test010320.Ex8
{
    //I didnt make abstract because this class has no properties.
    public interface IFitnessTrainingBuilder
    {
        void PreWorkout();
        void Cardio();
        void WeightTraining();
        void EndOfPractice();
        FitnessTraining GetFitness();

    }
}
