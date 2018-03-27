using System;
using Xunit;
using civil_engineering.essential.entities;

public class EntityId_test {
    
    [Fact]
    public void NotEqualsTest(){
        object o = new object();
        EntityId id = new EntityId("some");
        Assert.False( id.Equals(0));
    }
}
