using System;
using System.Collections.Generic;


namespace FamilyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Family Dictionary!");
            Console.WriteLine(new string('-', 50));


            Dictionary<string, Dictionary<string, string>>

            myFamily = new Dictionary<string, Dictionary<string, string>>();

            myFamily.Add("sister", new Dictionary<string, string>() { { "name", "Suzy" }, { "age", "49" } });
            myFamily.Add("mom", new Dictionary<string, string>() { { "name", "Shelly" }, { "age", "67" } } );
            myFamily.Add("dad", new Dictionary<string, string>() { { "name", "Ken" }, { "age", "68" } });
            myFamily.Add("wife", new Dictionary<string, string>() { { "name", "Beth"}, { "age", "38" } });





            var familyRole = new List<string>();
            
            var firstNames = new List<string>();

            var familyAges = new List<string>();





            // family role
            foreach (string role in myFamily.Keys)
            {
                familyRole.Add(role);
            }





            // names and ages
            foreach (var outerEntry in myFamily)
            {
               foreach (var innerKey in outerEntry.Value)
                {

                    if (innerKey.Key.Contains("name"))
                    {
                        firstNames.Add(innerKey.Value);
                    } 
                    else
                    {
                        familyAges.Add(innerKey.Value);
                    }
                }
            }



 
         
            for (int i = 0; i < firstNames.Count; i++)
            {
                Console.WriteLine($"{firstNames[i]} is my {familyAges[i]} year old {familyRole[i]}.");
            }




        }
    }
}
