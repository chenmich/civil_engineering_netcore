using System;
using civil_engineering.essential.entities;

namespace civil_engineering.parts
{
    public abstract class PartType:EntityType
    {
        public PartType(EntityId id):base(id){}
        public PartType():base(){}
    }

    public abstract class PersonType: PartType{
        public PersonType(EntityId id):base(id){}
        public PersonType(){}
    }

    public class EmployeerType:PersonType{
        public EmployeerType(EntityId id):this(){}
        public EmployeerType():base(){
            Id = new EntityId("Employeer");
        }
    }
}


