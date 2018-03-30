using System;

namespace civil_engineering.essential.entities
{
    public class Accountabilility: IAccountability
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

        public Accountabilility(IEntity parent, IEntity child, IAccountabilityType type, string name)
        :this(parent, child,type, new EntityId(name)){
            
        }
        public Accountabilility(IEntity parent, IEntity child, IAccountabilityType type, EntityId id){
            Id = id;
            Parent = parent;
            Child = child;
            parent.addChildrenAccountability(this);
            child.addParentAccountability(this);
            Type = type;
        }
    }
}
