using System;

namespace MoodAnalyser
{
    public class MoodAnalyser
    {
        public string AnalyseMood(string message)
        {
            if (message.Contains("sad", StringComparison.OrdinalIgnoreCase))
                return "Sad";
            else 
                return "Happy";
        }

        /// <summary>
        /// main method
        /// </summary>
        /// <param name="args"> no parameters </param>
        static void Main(string[] args)
        {
            // creating moood analyser object
            MoodAnalyser moodAnalyser = new MoodAnalyser();
            string mood = moodAnalyser.AnalyseMood("I am in Happy mood");
        }
    }
}
