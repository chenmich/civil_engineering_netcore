using System;
using civil_engineering.essential.entities;

namespace civil_engineering.parts
{
    public class PartBuilder
    {
        public virtual bool  addBelow(Part owner, Part affiliated ){
            throw new NotImplementedException("addBelow");
        }
        public virtual Person buildPerson(string name){
            return buildPerson(new EntityId(Guid.NewGuid(), name));
        }
        public virtual Person buildPerson(EntityId id){
            Person _person = new Person(id);
            return _person;
        }
        public virtual Company buildCompany(string name){
            return buildCompany(new EntityId(Guid.NewGuid(), name));
        }
        public virtual Company buildCompany(EntityId id){
            throw new NotImplementedException("buildCompany");
        }

        public virtual Branch buildBranch(){

            throw new NotImplementedException("buildBranch");
        }

        public virtual Command buildCommand(){
            throw new NotImplementedException("buildCommand");
        }

        public virtual OperationTeam buildOperationTeam(){
            throw new NotImplementedException("buildOperationTeam");
        }

        public virtual Department buildDepartment(){
            throw new NotImplementedException("buildDepartment");
        }

        public virtual Division buildDivision(){
            throw new NotImplementedException("buildDivision");
        }
    }
}
