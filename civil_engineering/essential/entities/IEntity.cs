using System;
using System.Linq;
using System.Collections.Generic;

namespace civil_engineering.essential.entities
{
    public interface IEntity: IEquatable<IEntity>, IEntityId
    {
        //void register();
        //void clearRegister();
        //IEntity get(string name);
        /*
            I prefer to use the parent and child for representing the relation master and slave, because
            Mr. Martin has said:
            "The use of parent and child is a very useful metaphor when discussing hierarchies, 
            or indeed any other kind of directed graph structure. "
        */
        HashSet<IEntity> Parent();
        HashSet<IEntity> Children();
        //IEnumerable<IEntity> Ancestors();
        //IEnumerable<IEntity> Descendents();
        //IEnumerable<IEntity> Siblings();
        void addParentAccountability(IAccountability accountability);
        void addChildrenAccountability(IAccountability accountability);
    }  

    public interface IAccountabilityType :IEntityId{

    }

    public interface IAccountability :IEntityId{
        
        IEntity Parent{
            get;
        }
        IEntity Child{
            get;
        }
        IAccountabilityType Type{
            get;
        }
    }

    public interface IEntityId{
        EntityId Id{
            get;
        }
    }
}
