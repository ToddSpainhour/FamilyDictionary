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


            var familyRole = new List<string>();
            
            var firstNames = new List<string>();

            var familyAges = new List<string>();



           








            // first names and ages
            foreach (var outerEntry in myFamily)
            {
               foreach (var innerKey in outerEntry.Value)
                {
                    //Console.WriteLine($"innerKey {innerKey.Value}");

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


            //foreach (string x in familyRole)
            //{
            //    Console.WriteLine($"{x}, {firstNames[x]}")
            //}

            




            // test loops to see if lists are working


            // family roles
            foreach (string role in myFamily.Keys)
            {
                Console.WriteLine($"their role is {role}");
                familyRole.Add(role);
            }

            Console.WriteLine(new string('-', 50));




            //names
            foreach (string name in firstNames)
            {
                Console.WriteLine($"their name is {name}");
            }

            Console.WriteLine(new string('-', 50));




            // ages
            foreach (string age in familyAges)
            {
                Console.WriteLine($"Their age is {age}");
            }

            Console.WriteLine(new string('-', 50));




            Console.WriteLine($"{firstNames[1]} is my {familyRole[1]} and is {familyAges[1]} years old");
            //Console.WriteLine($"test: {firstNames[1]}");
            //Console.WriteLine($"test: {familyRole[1]}");
            //Console.WriteLine($"test: {familyAges[1]}");












            /*
             * var input = "INAGX4 Agatti Island";
                var splitted = input.Split(new[] { ' ' }, 2);
                Console.WriteLine(splitted[0]); // INAGX4
                Console.WriteLine(splitted[1]); 
            */



            /*
           var source = new Dictionary<string, Dictionary<String, Object>>();

               foreach (var outerEntry in source)
               {
                   foreach (var innerEntry in outerEntry.Value)
                   {
                       if(innerEntry.Key == "Department")
                       {
                           // do something
                           Console.WriteLine("Key:{0} Value:{1}", innerEntry.Key, innerEntry.Value);
                       }
                   }
               }

            * */








            /*
            Next, iterate over each item in myFamily and produce the following output.
            'Krista is my sister and is 42 years old'
            */



        }
    }
}
