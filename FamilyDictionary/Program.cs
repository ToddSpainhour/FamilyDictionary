using System;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace FamilyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Family Dictionary!");

            /* 
                Define a Dictionary that contains information about several members of your family. 
                Use the following example as a template.
             */

            Dictionary<string, Dictionary<string, string>>

            myFamily = new Dictionary<string, Dictionary<string, string>>();

            myFamily.Add("sister", new Dictionary<string, string>() { { "name", "Suzy" }, { "age", "49" } });
            myFamily.Add("mom", new Dictionary<string, string>() { { "name", "Shelly" }, { "age", "67" } } );
            myFamily.Add("dad", new Dictionary<string, string>() { { "name", "Ken" }, { "age", "68" } });
            myFamily.Add("wife", new Dictionary<string, string>() { { "name", "Beth"}, { "age", "38" } });

            // list for all titles
            var familyRole = new List<string>();
            var firstNames = new List<string>();



            // family roles
            foreach ( string person in myFamily.Keys)
            {
                Console.WriteLine($"is my {person} and is years old.");
                familyRole.Add(person);
            }

            /*
            // first names
            foreach (KeyValuePair name in myFamily.Values)
            {
                Console.WriteLine(name.ToStr);
            }
            */

            Console.WriteLine(new string('-', 50));


            foreach (string person in familyRole )
            {
                Console.WriteLine($"This person's role is {person}");
            }
               









            /*
            Next, iterate over each item in myFamily and produce the following output.
            'Krista is my sister and is 42 years old'
            */



        }
    }
}
