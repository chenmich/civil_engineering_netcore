using System;
using System.Collections.Generic;

namespace civil_engineering.essential.entities{
    public  class Entity : IEntity
    {
        
        private static readonly Dictionary<EntityId, Entity> _entity_Collection
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
        public  bool Equals(IEntity other){
            if (ReferenceEquals(other, null))
                return false;
    
            if (ReferenceEquals(this, other))
                return true;
    
            return Id.Equals(other.Id);
        }

        public override bool Equals(object obj){
            //
            // See the full list of guidelines at
            //   http://go.microsoft.com/fwlink/?LinkID=85237
            // and also the guidance for operator== at
            //   http://go.microsoft.com/fwlink/?LinkId=85238
            //
            
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            
            // TODO: write your implementation of Equals() here
            Entity fooItem = obj as Entity;

            return fooItem.Id.Equals(this.Id);
        }
        public override int GetHashCode(){
            return Id.GetHashCode();
        }       

    }


    
}