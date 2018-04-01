using System;
using System.Collections.Generic;

namespace civil_engineering.essential.entities
{
    public class EntityType:IEntityType, IEquatable<EntityType>
    {
        
        public EntityType(EntityId id){
            Id = id;
        }
        public EntityId Id{get; private set;}
        
        //below content is for check equality

        // override object.Equals
        public override bool Equals(object obj)
        {            
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            EntityType _et = obj  as EntityType;
            return   this.Equals(_et);          
        }

        public bool Equals(EntityType obj){
            if (ReferenceEquals(obj, null))
                return false;
    
            if (ReferenceEquals(this, obj))
                return true;
    
            return this.Id.Equals(obj.Id);
        }
        
        // override object.GetHashCode
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public static   bool operator == (EntityType left, EntityType right){
            if (((object)left) == null || ((object)right) == null)
                return Object.Equals(left, left);
            return left.Equals(right);
        }
        public static  bool operator != (EntityType left, EntityType right){
            if (((object)left) == null || ((object)right) == null)
                return Object.Equals(left, left);
            return !left.Equals(right);
        }

        public override string ToString(){
            return Id.ToString();
        } 

    }


}


