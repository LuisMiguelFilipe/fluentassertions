using System;

#if NET45
using System.Runtime.Serialization;
#endif

namespace FluentAssertions.Execution
{
    /// <summary>
    /// Represents the default exception in case no test framework is configured.
    /// </summary>
#if NET45
    [Serializable]
#endif

    public class AssertionFailedException : Exception
    {
        public AssertionFailedException(string message) : base(message)
        {
            
        }

#if NET45

        protected AssertionFailedException(SerializationInfo info, StreamingContext context) 
            : base(info, context)
        {

        }
#endif

    }
}