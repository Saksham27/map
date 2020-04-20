using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyser
{
    class MoodAnalysisException : Exception
    {
        private ExceptionType _ExceptionType;
        public enum ExceptionType
        {
            EnteredNull
        }
        

        public MoodAnalysisException(ExceptionType exceptionType, string message) : base(message)
        {
            this._ExceptionType = 
        }
    }
}
