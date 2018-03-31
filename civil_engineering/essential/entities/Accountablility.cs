using System;
using civil_engineering.essential.Exceptions;

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
        private Accountability(IEntity parent, IEntity child, IAccountabilityType type, EntityId acc_id){
            Id = acc_id;
            Parent = parent;
            Child = child;
            parent.addChildrenAccountability(this);
            child.addParentAccountability(this);
            Type = type;
        }
        public static IAccountability create(Entity parent, Entity child, 
                                                IAccountabilityType accountability_type, EntityId accountability_id){
            if(!canCreate(parent, child, accountability_type))
                throw new InvalidAccountabilityException(parent, child, accountability_type, "Invalid Accountability");
            else
                return  new Accountability(parent, child, accountability_type, accountability_id);

        }
        static bool canCreate(Entity parent, Entity child, IAccountabilityType accountability_type){
            if(parent.Equals(child)) return false;
            if(parent.ancestorsInclude(child, accountability_type)) return false;
            return true; 
        }
    }
}
