using System;
using System.Collections.Generic;

namespace civil_engineering.essential.entities{
    public  class Entity : IEntity, IEntityId
    {
        
        private Dictionary<EntityId, Entity> _entity_Collection
            = new Dictionary<EntityId, Entity>();
        
        private  void register(){
            _entity_Collection.Add(Id, this);
        }

        public Entity(EntityId id){
            Id = id;
            register();
        }
        public EntityId Id{
            get;
            private set;
        }
        public virtual  ICollection<IEntity> Parent(){
            throw new NotImplementedException("The Children Method");
        }
        public virtual ICollection<IEntity> Children(){
            throw new NotImplementedException("The Parent Method");
        }

        public void addParentAccountability(IAccountability acc){
            throw new NotImplementedException("The AddParentAccountability Method");
        }
        public void addChildrenAccountability(IAccountability acc){
            throw new NotImplementedException("The addChildAccountability Method");
        }
        

    }


    
}