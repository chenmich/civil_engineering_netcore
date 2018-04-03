using System;
using civil_engineering.essential.entities;

namespace civil_engineering.parts
{
    public abstract class Part: Entity
    {
        public Part():base(){}
        public Part(EntityId id, IEntityType type):base(id, type){}
    }

    public class Person: Part
    {
        public Person():base(){
            Id.Id = Guid.NewGuid();
        }
        public Person(EntityId id, IEntityType type):base(id, type){}
    }
    

    public abstract class Organization: Part
    {
    }
    //公司
    public class Company:Organization{}
    //项目经理部
    public class Division:Organization{}
    //分公司
    public class Branch:Organization{}
    //部门
    public class Department:Organization{}
    //指挥部
    public class Command:Organization{}
    //作业队,架子队
    public class OperationTeam:Organization{}
    
}
