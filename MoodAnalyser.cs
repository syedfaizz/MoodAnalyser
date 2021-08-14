using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserProblem
{
    public class MoodAnalyser
    {
        public string message;
        public MoodAnalyser(string message)
        {
            this.message = message;
        }
        public string AnalyseMood()
        {
            try
            {
                message = message.ToLower();
                if (message.Contains("Happy"))
                    return "happy";
                else
                    return "SAD";
            }
            catch (NullReferenceException e)
            {
                return "happy";
            }
        }
    }
}