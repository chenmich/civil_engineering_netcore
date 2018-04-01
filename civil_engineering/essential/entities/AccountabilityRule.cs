using System;

namespace civil_engineering.essential.entities
{
    public class AccountabilityRule
    {
        public  IEntityType AlloweParent{
            get; private set;
        }
        public IEntityType AlloweChild{
            get; private set;
        }
        public AccountabilityRule(IEntityType alloweParent, IEntityType alloweChild){
            AlloweParent = alloweParent;
            AlloweChild = alloweChild;
        }
    }
}
