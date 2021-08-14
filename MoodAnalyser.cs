using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserProblem
{
    public class MoodAnalyser
    {
        public static string AnalyseMood(string message)
        {
            message = message.ToLower();
            if (message.Contains("Sad"))
                return "SAD";
            else
                return "HAPPY";
        }
    }
}