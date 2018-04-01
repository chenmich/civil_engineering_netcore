using System;
using System.Collections.Generic;

namespace civil_engineering.essential.entities
{
    public class EntityType:IEntityType
    {
        
        public EntityType(EntityId id){
            Id = id;
        }
        public EntityId Id{get; private set;}
        
    }


}


