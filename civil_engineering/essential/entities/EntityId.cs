using System;

namespace civil_engineering.essential.entities
{
    public  class EntityId: IEquatable<EntityId>
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
        public EntityId(string name):this(Guid.NewGuid(), name){}

        //The content below are for the test equality between two object
        public bool Equals(EntityId other)
        {
            if (ReferenceEquals(other, null))
                return false;
    
            if (ReferenceEquals(this, other))
                return true;
    
            return Name.Equals(other.Name) && Id.Equals(other.Id);
            
        }
        public override string ToString(){
            return string.Format("EntityID({0}, {1})", Id.ToString(), Name.ToString());
        }

        public override int GetHashCode(){
            return Id.GetHashCode();
        }

        
        public override bool Equals(object obj)
        {
            if (obj == null || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            EntityId entityId = obj as EntityId;

            return entityId.Id.Equals(this.Id);
        }
        public static bool  operator == (EntityId id1, EntityId id2){
            if (((object)id1) == null || ((object)id2) == null)
                return Object.Equals(id1, id2);
            return id1.Equals(id2);
        }
        public static bool operator != (EntityId id1, EntityId id2){
            if (((object)id1) == null || ((object)id2) == null)
                return !Object.Equals(id1, id2);
            return !id1.Equals(id2);
        }
    
    
        
        
        
    }
}
