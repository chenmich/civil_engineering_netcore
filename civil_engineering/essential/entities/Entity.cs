using System;
using System.Collections.Generic;

namespace civil_engineering.essential.entities{
    public abstract class Entity
    {
        protected static Dictionary<string, Entity> instance = new Dictionary<string, Entity>();
        public Entity(){}
        public string name{
            get;
        } 
        void register(){
            instance.Add(name, this);
        }
        public static Entity get(string name){
            return instance[name];
        }
        protected HashSet<Entity> parents()
        {
            return new HashSet<Entity>(); 
        }
    }

    public class Bridge:Entity{
        
        public static  void one(){
           Bridge x = new Bridge();
           Entity.instance.Add("11", x);
        }
        
    }

    public class stay_bridge: Bridge{
        public static void some(){
            stay_bridge y = new stay_bridge();
            Entity.instance.Add("22", y);
        }
    }
    
}