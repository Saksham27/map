using System;

namespace MoodAnalyser
{
    class MoodAnalyser
    {
        public string AnalyseMood(string message)
        {
            if (message.Contains("sad", StringComparison.OrdinalIgnoreCase))
                return "Sad Mood";
            else 
                return "Happy Mood";
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
