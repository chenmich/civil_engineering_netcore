using System;

namespace civil_engineering.essential.Exceptions
{
    public class EntityException : System.Exception
    {
        public EntityException() :base(){}
        public EntityException(string message) : base(message) { }
        public EntityException(string message, System.Exception inner) : base(message, inner) { }
        protected EntityException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }

}
