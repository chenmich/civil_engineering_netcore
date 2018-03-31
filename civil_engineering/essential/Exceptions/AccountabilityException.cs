using System;
using civil_engineering.essential.entities;

namespace civil_engineering.essential.Exceptions
{
    [System.Serializable]
    public class AccountabilityException : System.Exception
    {
        public IEntity Parent{
            get;
            private set;
        }
        public IEntity Child{
            get;
            private set;
        }
        public IAccountabilityType Type{
            get;
            private set;
        }

        public AccountabilityException(IEntity parent, IEntity child, IAccountabilityType type, string message):
            base(message){
                Parent = parent;
                Child = child;
                Type = type;
            }
        public  AccountabilityException() { }
        public AccountabilityException(string message) : base(message) { }
        public AccountabilityException(string message, System.Exception inner) : base(message, inner) { }
        protected AccountabilityException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }

    [System.Serializable]
    public class InvalidAccountabilityException : AccountabilityException
    {
        public InvalidAccountabilityException() { }
        public InvalidAccountabilityException(string message) : base(message) { }
        public InvalidAccountabilityException(string message, System.Exception inner) : base(message, inner) { }
        protected InvalidAccountabilityException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
        public InvalidAccountabilityException(IEntity parent, IEntity child, 
                                IAccountabilityType accountability_type, string message):
            base(parent, child, accountability_type, message){}
    }
    
}
