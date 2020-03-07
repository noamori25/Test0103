using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test010320.Ex8
{
    public class FitnessTraining
    {
        public string PreWorkout { get; set; }
        public string Cardio { get; set; }
        public string WeightTraining { get; set; }
        public string EndOfPractice { get; set; }

        public override string ToString()
        {
            return $"{PreWorkout}, {Cardio}, {WeightTraining}, {EndOfPractice}";
        }
    }
}
