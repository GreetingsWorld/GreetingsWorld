using System.Runtime.Serialization;

namespace GreetingsWorld.Models
{
    [Serializable]
    internal class ResourceNotFound : Exception
    {
        public ResourceNotFound()
        {
        }

        public ResourceNotFound(string? message) : base(message)
        {
        }

        public ResourceNotFound(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected ResourceNotFound(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}