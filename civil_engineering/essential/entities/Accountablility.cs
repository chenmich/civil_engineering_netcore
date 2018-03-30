using System;

namespace civil_engineering.essential.entities
{
    public class Accountability: IAccountability
    {
        public EntityId Id{
            get;
            private set;
        }

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

        public Accountability(IEntity parent, IEntity child, IAccountabilityType type, string acc_name)
        :this(parent, child,type, new EntityId(acc_name)){
            
        }
        public Accountability(IEntity parent, IEntity child, IAccountabilityType type, EntityId acc_id){
            Id = acc_id;
            Parent = parent;
            Child = child;
            parent.addChildrenAccountability(this);
            child.addParentAccountability(this);
            Type = type;
        }
        public static void create(IEntity parent, IEntity child, IAccountabilityType type, string acc_name){
            Accountability.create(parent, child, type, new EntityId(acc_name));
        
        }
        public static void create(IEntity parent, IEntity child, IAccountabilityType type, EntityId acc_id){
            throw new NotImplementedException("The Accountability' create method for EntityId id");
        }
    }
}
