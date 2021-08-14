using System;

namespace MoodAnalyserProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = MoodAnalyser.AnalyseMood("I am Happy");
            Console.WriteLine("Mood is " + message);
        }
    }
}
