using System.Collections.Generic;

namespace Generic_Collections_ZooSys
{
    // Logic of Add age >10 years
    class animalsList:List<Animals>
    {
        // New Hiding for add list to rechange signture again
        public new void Add(Animals animals)
        {
            if (animals.Age < 10)
            { 
                base.Add(animals);
                
            }
           
        }

        
    }
}