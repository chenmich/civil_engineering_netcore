using System;
using Xunit;
using civil_engineering.essential.entities;

namespace civil_engineering_test.essential_test
{
    public class EntityConnectTest
    {
        AccountabilityType affiliation = new AccountabilityType("Affiliation");
        AccountabilityType leardership = new AccountabilityType("leadership");
        Entity some_com = new Entity(new EntityId("Wtwj"));
        Entity zs = new Entity(new EntityId("zs"));
        Entity ls = new Entity(new EntityId("ls"));

        void setup(){
            new Accountabilility(some_com, zs, affiliation);
            new Accountabilility(some_com, ls, affiliation);
        }

        [Fact]
        public void SimpleTest()
        {
            setup();
            Assert.True(some_com.Children().Contains(zs));
            Assert.True(ls.Parent().Contains(some_com)); 
        }

        [Fact]
        public void testParent(){
            setup();
            new Accountabilility(zs, ls, leardership);
            Assert.True(ls.Parent().Contains(some_com));
            Assert.True(ls.ParentBy(leardership).Contains(zs));
            Assert.Equal(ls.Parent().Count, 2);
            Assert.Equal(ls.ParentBy(leardership).Count, 1);
            Assert.Equal(ls.ParentBy(affiliation).Count, 1);
            Assert.True(zs.ParentBy(affiliation).Contains(some_com));
        }
    }
}
