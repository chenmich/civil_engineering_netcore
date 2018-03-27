using System;

namespace civil_engineering.essential.entities
{
    public class EntityId: IEquatable<EntityId>
    {
        private Guid _guid = Guid.NewGuid();
        private string _name;
        public Guid Id{
            get;
        }
        public string name{
            get{
                return _name;
            }
        }
        public EntityId(string name){
            _name = name;
        }

        public bool Equals(EntityId other)
        {
            if (ReferenceEquals(other, null))
                return false;
    
            if (ReferenceEquals(this, other))
                return true;
    
            return name.Equals(other.name) && Id.Equals(other.Id);
            
        }
        public override string ToString(){
            return _guid.ToString() + "   " + _name;
        }

        public override int GetHashCode(){
            return _guid.GetHashCode() + _name.GetHashCode();
        }
        
    }
}
