using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyser
{
    public class MoodAnalysisException : Exception
    {
        
        public enum ExceptionType
        {
            EnteredNull
        }

        readonly ExceptionType exceptionType;

        public MoodAnalysisException(ExceptionType exceptionType, string exceptionMessage):base(exceptionMessage)
        {
            this.exceptionType = exceptionType;
            
        }
    }
}
