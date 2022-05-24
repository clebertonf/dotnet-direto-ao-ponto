using System;

namespace DevFreela.Core.Exceptions
{
    public class ProjectAlreadyStartedException : Exception
    {
        public ProjectAlreadyStartedException() : base("Project is already in started status")
        {
        }

        public ProjectAlreadyStartedException(string message) : base(message)
        {
        }

        public ProjectAlreadyStartedException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
