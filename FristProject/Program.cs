using System;

namespace FristProject
{
  // Move this class to a file by itself
  // call the file 
  // Person.cs
  //
    public class Person
    {
        public string Name;
        public int Age;
        public bool HasPet;

        public void Greeting()
        {
            Console.WriteLine("Hi! My name is " + Name + " and my age is " + Age);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Person is a new type because you created 
            // I mean it is not a predefined type like int32 and string
            // change this line to 
            // var person = new Person();
            // we use keyword var since the compiler knows that you are trying to create a new variable called 'person'
            // of type 'Person' - 
            // 
            Person person = new Person();

            person.Name = "Sofiane";
            person.Age = 16;
            person.HasPet = true;

            person.Greeting();
        }
    }
}
