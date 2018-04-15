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
        public void buildPersonTest(){
            PartBuilder builder = new PartBuilder();
            Person employeer_zs = builder
                .buildPerson(new EntityId("zs"), 
                                new EmployeerType());
            Person employeer_ls = builder
                .buildPerson(new EntityId("ls"), new EmployeerType());
            builder.setAccountability(employeer_zs, employeer_ls, 
                    new leardAccountabilityType());

            
        }

    }
}

