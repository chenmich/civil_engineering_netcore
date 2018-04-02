using System;
using civil_engineering.essential.entities;

namespace civil_engineering.essential.parts
{
    public abstract class Part: Entity
    {
    }

    public class Person: Part
    {
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
    
}
