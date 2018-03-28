using System;

namespace civil_engineering.essential.entities
{
    public class EntityId: IEquatable<EntityId>
    {        
        public Guid Id{
            get;
            private set;
        }
        public string Name{
            get;
            private set;
        }
        public EntityId(Guid id, string name){
            Name = name;
            Id = id;
        }
        public EntityId(string name):this(Guid.NewGuid(), name){
            
        }

        public bool Equals(EntityId other)
        {
            if (ReferenceEquals(other, null))
                return false;
    
            if (ReferenceEquals(this, other))
                return true;
    
            return Name.Equals(other.Name) && Id.Equals(other.Id);
            
        }
        public override string ToString(){
            return Id.ToString() + "   " + Name;
        }

        public override int GetHashCode(){
            return Id.GetHashCode() + Name.GetHashCode();
        }
        
    }
}
