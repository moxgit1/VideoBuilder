using System;
using System.Collections.Generic;
using System.Linq;
namespace TestProject
{

public abstract class Drink
    {
        public readonly string Carbonated = "carbonated";
        public readonly string NotCarbonated = "not carbonated";

        //drink name, whether it is carbonated, and a calculated 
        //description of the drink
        public string Name{get; protected set;}


        public bool IsCarbonated{ get; protected set;}
        
        //The description should be overridden in each type so 
        //that for a soda it includes the soda name and if it is 
        //carbonated, a juice should also include the fruit name, a beer should add the alcohol content.

        public string CarbonatedDescription{get {

            return IsCarbonated ? Carbonated : NotCarbonated;
        }}

        public override string ToString()
        {
            return $"{Name}, {CarbonatedDescription}";
        }

       //
        public virtual string Description() => ToString();
        
    }

    public class Beer : Drink
    {
        public Beer(string name, string alcoholContent)
        {
            IsCarbonated = true;
            Name = name;
            AlcoholContent = alcoholContent;
        }

        //the beer should have a property that indicates the alcohol content
        public string AlcoholContent {get; private set;}

        public  override string Description()
        {
            return $"{ToString()}, {AlcoholContent}.";
        }
    }

    public class Juice : Drink
    {
        //The juice derived type should have a string property that
        // indicates the fruit the juice is made from

        public Juice(string fruitType, String juiceMadeFrom)
        {
            IsCarbonated = false;
            Name = fruitType;
            JuiceMadeFrom = juiceMadeFrom;
      
        }           
          
        public string JuiceMadeFrom {get; private set;}


        public override  string Description()
        {
            return $"{ToString()}, {JuiceMadeFrom}.";
        }


    }
    public class Soda : Drink
    {

        public Soda(string name)
        {
            IsCarbonated = true;
            Name = name;
        }
    }
}
