using NUnit.Framework;
using MoodAnalyser;

namespace MoodAnalyser.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        // Test Case 1.1
        [Test]
        public void GivenSadMood_ShouldReturnSad()
        {
            string expected = "Sad";
            string message = "I am in Sad mood";
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);
            string mood = moodAnalyser.AnalyseMood();
            Assert.AreEqual(expected, mood);
        }

       
    }
}