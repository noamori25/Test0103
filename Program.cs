using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test010320.Ex10;
using Test010320.Ex6;
using Test010320.Ex8;
using Test010320.Part2;

namespace Test010320
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ex2 Part2
            List<object> operations = new List<object>();


            //Builder Ex8
            FitnessCreator MyFitness = new FitnessCreator(new FitnessBuilderA());
            MyFitness.CreateFitness();
            Console.WriteLine(MyFitness.GetFitnessTraining() + " A");

            MyFitness = new FitnessCreator(new FitnessBuilderB());
            MyFitness.CreateFitness();
            Console.WriteLine(MyFitness.GetFitnessTraining() + " B");

            //Visitor Ex6
            Circle c = new Circle("Im Circle");
            IVisitor threeD = new Visitor3D();
            Console.WriteLine($"3D = {c.Accept(threeD)}");

            Rectangle r = new Rectangle("Im rectangle");
            IVisitor twoD = new Visitor2D();
            Console.WriteLine($"2D = {r.Accept(twoD)}");

            Triangle t = new Triangle("Im triangle");
            IVisitor update = new VisitorUpdateResolution();
            Console.WriteLine(t.Accept(update));
            Console.WriteLine(t.Accept(twoD));

            //Decorator Ex10
            IWindow windowBase = new Shading(new _3DLight(new ColorFrame(new BaseWindow())));
            Console.WriteLine(windowBase.GetDetails());

            //Part2 Ex1
            List<string> words = new List<string>
            { "java", "jjava", "vaj", "aavj", "j", "vjaa", "dan", "and", "ddan" };
            ListWordsOperation.findDuplicateWords(words);
          

        }
    }
}
