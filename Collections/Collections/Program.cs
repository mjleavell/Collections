using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            // var arrayOfObjects = new object[5]; //creating an array that has 5 spots
            var studentsWithBlackHair = new List<string> { "Nathan", "Austin", "Marty McFly" }; // {} is collection initialization bc youre initializing a collection


            // <> means that it is a generic type
            // key is unique and can only be in the dictionary one time
            var studentsByHairColor = new Dictionary<string, List<string>> //dictionaries are made up of 2 types
            {
                {"Black", studentsWithBlackHair }
            };

            studentsByHairColor.Add("Bald", new List<string> { "Martin" });
            // studentsByHairColor.Add("Bald", new List<string> { "Adam" }); // throws an error because you cant have a new list with the same key
            studentsByHairColor.["Black"].Add("Maggie");

            // Getting Something Out of a Dictionary
            var theBlackHairedStudents = studentsByHairColor["Black"]; //returns a list because the value is a list

            // when one of them changes, they both change because they are storing pointers to their location
            // if you change one of hte variables, then they all change
            if (theBlackHairedStudents  == studentsWithBlackHair)
            {
                Console.WriteLine("they are the same");
            }


            // foreach (var kvp in studentsByHairColor) 
            // foreach (var (key, value) in studentsByHairColor)

            // uses C# library called the value tupple(sp?) and allows methods to return multiple things
            foreach (var (hairColor, students) in studentsByHairColor) //example of how you would destructure kvp
            {
                Console.WriteLine($"The following students have {hairColor}");

                students.Add("Shane");

                foreach (var student in students)
                {
                    Console.WriteLine(student);
                }
            }

            Console.ReadLine();
        }
    }
}
