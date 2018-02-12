using System;

public class Program
    {
        public static void Main(string[] args)
        {
        int numberOfPeople = int.Parse(Console.ReadLine());

        
        Family family = new Family();

            for (int i = 0; i < numberOfPeople; i++)
            {
                var personInfo = Console.ReadLine().Split();

            Person person = new Person();

            string personName = person.Name;
                int personAge = person.Age;

            family.AddMember(person);          
            
            }

            Person oldestPerson = family.GetOldestMember();

            Console.WriteLine($"{oldestPerson.Name} {oldestPerson.Age}");

        }
    }

