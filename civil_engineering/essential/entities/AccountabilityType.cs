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
        
        //below content are for test equality of two object

        public override bool Equals(object obj){
            if (obj == null || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            AccountabilityType _acc = obj as AccountabilityType ;

            return _acc.Id.Equals(this.Id);
        }
        public override int GetHashCode(){
            return Id.GetHashCode();
        }
        public bool Equals(AccountabilityType other){
            if (ReferenceEquals(other, null))
                return false;
    
            if (ReferenceEquals(this, other))
                return true;
    
            return Id.Equals(other.Id);
        }
        public static bool operator == (AccountabilityType type1, AccountabilityType type2){
            if (((object)type1) == null || ((object)type2) == null)
                    return Object.Equals(type1, type2);

            return type1.Equals(type2);
        }
        public static bool operator != (AccountabilityType type1, AccountabilityType type2){
            if (((object)type1) == null || ((object)type2) == null)
                    return !Object.Equals(type1, type2);

            return !type1.Equals(type2);
        }

    }

}
