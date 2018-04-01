using System;
using civil_engineering.essential.entities;
using civil_engineering.essential.Exceptions;
using Xunit;

public class EntityKnowledgeTest{
    static EntityType com = new EntityType(new EntityId("Some com"));
    static EntityType employeer = new EntityType(new EntityId("Employeer"));
    static EntityType leader = new EntityType(new EntityId("leader"));
    static EntityType customer = new EntityType(new EntityId("Customer"));

    static AccountabilityType appointment = new AccountabilityType(
                                                new EntityId("Appointment"));
    static AccountabilityType supervision = new AccountabilityType(
                                                new EntityId("Supervision"));
    Entity some_com = new Entity("some", com);
    Entity zs = new Entity("zs", employeer);
    Entity ls = new Entity("ls", employeer);
    void setUp(){
        appointment.addRule(com, leader);
        appointment.addRule(com, employeer);
        supervision.addRule(employeer, employeer);
        supervision.addRule(leader, employeer);
        supervision.addRule(leader, customer);        
    }
    [Fact]
    public void testRule(){
        Assert.Throws<NotStisfiedRuleAccountabilityException>(
            ()=> Accountability.create(zs, some_com, appointment, 
                                    new EntityId("zs appoint some_com")));
        Assert.True(some_com.Parent().Contains(zs));
    }

}