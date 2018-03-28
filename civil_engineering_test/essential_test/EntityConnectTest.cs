using System;
using Xunit;
using civil_engineering.essential.entities;

namespace civil_engineering_test.essential_test
{
    public class EntityConnectTest
    {
        AccountabilityType affiliation = new AccountabilityType("Affiliation");

        Entity wtwj = new Entity(new EntityId("Wtwj"));
        Entity zs = new Entity(new EntityId("zs"));
        Entity ls = new Entity(new EntityId("ls"));


        [Fact]
        public void SimpleTest()
        {
            new Accountablility(wtwj, zs, affiliation);
            new Accountablility(wtwj, ls, affiliation);
            Assert.True(wtwj.Children().Contains(zs));
            Assert.True(ls.Parent().Contains(wtwj)); 
        //Given
        
        //When
        
        //Then
        }
    }
}
