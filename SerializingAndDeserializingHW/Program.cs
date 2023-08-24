using System;
using System.Xml;
using System.Xml.Linq;
using Newtonsoft.Json;

namespace SerializingAndDeserializingHW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person()
            {
                Name = "Alan",
                Surname = "Ford",
                Age = 33,
            };

            Course course1 = new Course("Mathematics", "3");
            Course course2 = new Course("Physics", "2");
            Course course3 = new Course("Chemistry", "4");

            person1.AddCourse(course1);
            person1.AddCourse(course2);
            person1.AddCourse(course3);

            string person1Serialized = JsonConvert.SerializeObject(person1, Newtonsoft.Json.Formatting.Indented);

            File.WriteAllText("OnePerson.json", person1Serialized);

            string person1FromJson = File.ReadAllText("OnePerson.json");

            Person person1Deserialized = JsonConvert.DeserializeObject<Person>(person1FromJson);

            Console.WriteLine($"Name: {person1Deserialized.Name}");
            Console.WriteLine($"Surname: {person1Deserialized.Surname}");
            Console.WriteLine($"Age: {person1Deserialized.Age}");
            Console.WriteLine($"Course 1 Name: {course1.Name}. Grade: {course1.Grade}");
            Console.WriteLine($"Course 2 Name: {course2.Name}. Grade: {course2.Grade}");
            Console.WriteLine($"Course 3 Name: {course3.Name}. Grade: {course3.Grade}");
        }
    }
}
