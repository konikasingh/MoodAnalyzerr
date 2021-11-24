using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    public class CustomMoodAnException : Exception
    {
        public ExceptionType type;
        public enum ExceptionType
        {
            NULL_VALUE, EMPTY_MESSAGE, NO_SUCH_FIELD, NO_SUCH_METHOD,
            NO_SUCH_CLASS, OBJECT_CREATION_ISSUE

        }

        public CustomMoodAnException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }

        public static object CreateMoodAnalyse(string v1, string v2)
        {
            throw new NotImplementedException();
        }
    }
}
