using System;
using System.Collections.Generic;
using Xunit;
using civil_engineering.parts;
using civil_engineering.essential.entities;

namespace civil_engineering_test.part_test
{
    public class buildPartTest
    {
        [Fact]
        public void buildPerson_Organization_relationTest(){
            PartBuilder builder = new PartBuilder();
            Person _person1 = builder.buildPerson("zs");
            Person _person2 = builder.buildPerson(new EntityId(Guid.NewGuid(), "ls"));
            Company _company = builder.buildCompany("Tompson Brothers");
            Assert.True(builder.addBelow(_company, _person1));
            Assert.False(builder.addBelow(_person2, _company));            
        }

    }
}

