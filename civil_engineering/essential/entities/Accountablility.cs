using System;

namespace civil_engineering.essential.entities
{
    public class Accountablility: IAccountability
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

        public Accountablility(IEntity parent, IEntity child, IAccountabilityType type){
            Parent = parent;
            Child = child;
            parent.addChildrenAccountability(this);
            child.addParentAccountability(this);
        }
    }
}
