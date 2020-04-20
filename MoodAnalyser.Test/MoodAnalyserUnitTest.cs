using NUnit.Framework;
using MoodAnalyser;
using System;

namespace MoodAnalyser.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        /// <summary>
        /// Test Case 1.1 : Given "I am in Sad mood message", Test will pass if moodAnalyser Returns "Sad"
        /// </summary>
        [Test]
        public void GivenSadMood_ShouldReturnSad()
        {
            string expected = "Sad";
            string message = "I am in Sad mood";
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);
            string mood = moodAnalyser.AnalyseMood();
            Assert.AreEqual(expected, mood);
        }

        /// <summary>
        /// Test Case 1.2 : Given "I am in any mood message", Test will pass if moodAnalyser Returns "Happy"
        /// </summary>
        [Test]
        public void GivenAnyMood_ShouldReturnHappy()
        {
            string expected = "Happy";
            string message = "I am in any mood";
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);
            string mood = moodAnalyser.AnalyseMood();
            Assert.AreEqual(expected, mood);
        }

        /// <summary>
        /// Test Case 2.1 : Given null , Test will pass if moodAnalyser Returns "Happy"
        /// </summary>
        [Test]
        public void GivenNullMood_ShouldReturnHappy()
        {
            string expected = "Happy";
            string message = null;
            MoodAnalyser moodAnalyser = new MoodAnalyser();
            string mood = moodAnalyser.AnalyseMood();
            Assert.AreEqual(expected, mood);
        }

        /// <summary>
        /// Test Case 2.1 : Given null , Test will pass if moodAnalyser throws MoodAnalysisException
        /// </summary>
        [Test]
        public void GivenNullMood_ShouldThrowException()
        {
            string expected = "Enetered Null, Please Enter Proper Mood";
            MoodAnalyser moodAnalyser = new MoodAnalyser(null);
            string mood = moodAnalyser.AnalyseMood();
            Assert.AreEqual(expected, mood);
        }
    }
}