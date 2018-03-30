using System;
using Xunit;
using civil_engineering.essential.entities;

namespace civil_engineering_test.essential_test
{
    public class EntityConnectTest
    {
        AccountabilityType affiliation = new AccountabilityType("Affiliation");
        AccountabilityType leadership = new AccountabilityType("leadership");
        Entity some_com = new Entity(new EntityId("some"));
        Entity zs = new Entity(new EntityId("zs"));
        Entity ls = new Entity(new EntityId("ls"));

        void setup(){
            new Accountability(some_com, zs, affiliation, "zs in some_com");
            new Accountability(some_com, ls, affiliation, "ls in some_com");
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
            new Accountability(zs, ls, leadership, "zs is leader of ls");
            Assert.True(ls.Parent().Contains(some_com));
            Assert.True(ls.ParentBy(leadership).Contains(zs));
            Assert.Equal(ls.Parent().Count, 2);
            Assert.Equal(ls.ParentBy(leadership).Count, 1);
            Assert.Equal(ls.ParentBy(affiliation).Count, 1);
            Assert.True(zs.ParentBy(affiliation).Contains(some_com));
        }

        [Fact]
        public void testCycle(){
            Accountability.create(zs, ls, leadership, "zs lead the ls");
            Assert.Throws<Exception>(()=>Accountability.create(ls, zs, leadership, "ls lead the zs"));
            Assert.True(!zs.Parent().Contains(ls));
            AccountabilityType modelMentor = new AccountabilityType("Model Mentor");
            Accountability.create(ls, zs, modelMentor, "ls is Mentor");
            Assert.True(zs.Parent().Contains(ls));
        }
    }
}
