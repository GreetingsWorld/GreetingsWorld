using System.Runtime.Serialization;

namespace GreetingsWorld.Models
{
    [Serializable]
    internal class TypeNotFound : Exception
    {
        public TypeNotFound()
        {
        }

        public TypeNotFound(string? message) : base(message)
        {
        }

        public TypeNotFound(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected TypeNotFound(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}