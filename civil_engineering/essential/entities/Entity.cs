using System;
using System.Collections.Generic;

namespace civil_engineering.essential.entities{
    public  class Entity : IEntity
    {       
        private static readonly Dictionary<EntityId, Entity> _entity_Collection
            = new Dictionary<EntityId, Entity>();
        private static readonly HashSet<IAccountability> _parent_acc = new HashSet<IAccountability>();
        private static readonly HashSet<IAccountability> _children_acc = new HashSet<IAccountability>(); 
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
        public virtual  HashSet<IEntity> Parent(){
            HashSet<IEntity> _result = new HashSet<IEntity>();
            foreach(IAccountability acc  in _parent_acc){
                _result.Add(acc.Parent);
            }
            return _result;
        }
        public virtual HashSet<IEntity> ParentBy(IAccountabilityType accountability_type){
            HashSet<IEntity> _result = new HashSet<IEntity>();
            foreach(IAccountability acc in _parent_acc){
                if (acc.Equals(accountability_type)) _result.Add(acc.Parent);
            }
            return _result;
        }

        public virtual HashSet<IEntity> Children(){
            HashSet<IEntity> _result = new HashSet<IEntity>();
            foreach(IAccountability acc in _children_acc){
                _result.Add(acc.Child);
            }
            return _result;
        }

        public void addParentAccountability(IAccountability accountability){
            _parent_acc.Add(accountability);
        }
        public void addChildrenAccountability(IAccountability accountability){
            _children_acc.Add(accountability);
        }



        //The content below are for test quality between two objects
        public  bool Equals(IEntity other){
            if (ReferenceEquals(other, null))
                return false;
    
            if (ReferenceEquals(this, other))
                return true;
    
            return Id.Equals(other.Id);
        }

        public override bool Equals(object obj){
            if (obj == null || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            Entity entity = obj as Entity;

            return entity.Id.Equals(this.Id);
        }
        public override int GetHashCode(){
            return Id.GetHashCode();
        }

        public static bool operator == (Entity entity1, Entity entity2){
            if (((object)entity1) == null || ((object)entity2) == null)
                    return Object.Equals(entity1, entity2);

            return entity1.Equals(entity2);
        }
        public static bool operator !=(Entity entity1, Entity entity2){
            if (((object)entity1) == null || ((object)entity2) == null)
                    return !Object.Equals(entity1, entity2);

            return !entity1.Equals(entity2);

        }   

    }


    
}