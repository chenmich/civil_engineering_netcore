using System;
using Xunit;
using civil_engineering.essential.entities;

namespace civil_engineering_test.essential_test
{
    public class EntityConnectTest
    {
        AccountabilityType affiliation = new AccountabilityType("Affiliation");

        Entity some_com = new Entity(new EntityId("Wtwj"));
        Entity zs = new Entity(new EntityId("zs"));
        Entity ls = new Entity(new EntityId("ls"));


        [Fact]
        public void SimpleTest()
        {
            new Accountablility(some_com, zs, affiliation);
            new Accountablility(some_com, ls, affiliation);
            Assert.True(some_com.Children().Contains(zs));
            Assert.True(ls.Parent().Contains(some_com)); 
        //Given
        
        //When
        
        //Then
        }
    }
}
