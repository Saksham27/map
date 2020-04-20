﻿using System;

namespace MoodAnalyser
{
    public class MoodAnalyser : Exception
    {
        /// <summary>
        /// private field message
        /// </summary>
        private string _message;

        /// <summary>
        /// getter and setter property for _message
        /// </summary>
        private string Message
        {
            get { return this._message;  }
            set { this._message = value; }
        }

        /// <summary>
        /// default constuctor
        /// </summary>
        public MoodAnalyser() { }

        /// <summary>
        /// parametrized constructor
        /// </summary>
        /// <param name="message"> string type message </param>
        public MoodAnalyser(string message)
        {
            this.Message = message;
        }


        public string AnalyseMood()
        {
            try
            {
                if (this.Message.Contains("sad", StringComparison.OrdinalIgnoreCase))
                    return "Sad";
                else
                    return "Happy";
            }
            catch (NullReferenceException exception)
            {
                Console.WriteLine($"Null message exception : {exception.Message}");
                return "Happy";
            }
                     
                
        }

        /// <summary>
        /// main method
        /// </summary>
        /// <param name="args"> no parameters </param>
        static void Main(string[] args)
        {
            // creating moood analyser object
            MoodAnalyser moodAnalyser = new MoodAnalyser(null);
            string mood = moodAnalyser.AnalyseMood();
            Console.WriteLine(mood);
        }
    }
}
