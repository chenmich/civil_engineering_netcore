using System;
using Xunit;
using civil_engineering.essential.entities;

public class EntityId_test {
    
    [Fact]
    public void NotEqualsTest(){
        object o = new object();
        EntityId id = new EntityId("some");
        Assert.False(id.Equals(0));

        Guid gid = Guid.NewGuid();
        EntityId oneid = new EntityId("one");
        EntityId anotherid = new EntityId("one");
        Assert.False(oneid.Equals(anotherid));

        EntityId onestringid = new EntityId(gid, "one");
        EntityId anotherstringid = new EntityId(gid, "another");
        Assert.False(onestringid.Equals(anotherstringid));
    }

    [Fact]
    public void EqualsTest()
    {
        Guid gid = Guid.NewGuid();
        EntityId one = new EntityId(gid, "one");
        EntityId another = new EntityId(gid, "one");
        Assert.True(one.Equals(another));
    //When
    
    //Then
    }
}
