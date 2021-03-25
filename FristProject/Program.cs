using System;

namespace FristProject
{
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
            Person person = new Person();

            person.Name = "Sofiane";
            person.Age = 16;
            person.HasPet = true;

            person.Greeting();
        }
    }
}
