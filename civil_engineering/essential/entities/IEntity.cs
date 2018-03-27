using System;
using System.Linq;
using System.Collections.Generic;

namespace civil_engineering.essential.entities
{
    public interface IEntity
    {
        void register();
        void clearRegister();
        IEntity get(string name);
        /*
            I prefer to use the parent and child for representing the relation master and slave, because
            Mr. Martin has said:
            "The use of parent and child is a very useful metaphor when discussing hierarchies, 
            or indeed any other kind of directed graph structure. "
        */
        IEnumerable<IEntity> getParent();
        ISet<IEntity> getChildren();
        ISet<IEntity> getAncestors();
        ISet<IEntity> getDescendents();
        ISet<IEntity> getSiblings();
        Dictionary<string, string> x();
    }
}
