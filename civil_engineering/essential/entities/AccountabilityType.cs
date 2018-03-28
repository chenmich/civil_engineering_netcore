using System;

namespace civil_engineering.essential.entities
{
    public class AccountabilityType: IAccountabilityType
    {
        public EntityId Id{
            get;
            private set;
        }
        public AccountabilityType(EntityId id){
            Id = id;
        }
        public AccountabilityType(string name):this(new EntityId(name)){}
    }
}
