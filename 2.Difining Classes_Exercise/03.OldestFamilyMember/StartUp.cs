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

                person.Name = personInfo[0];
                person.Age = int.Parse(personInfo[1]);

                family.AddMember(person);          
            
            }

            //Task3

            //Person oldestPerson = family.GetOldestMember();

            //Console.WriteLine($"{oldestPerson.Name} {oldestPerson.Age}");

        //Task4
        family.GetAllPersonAfter30();

        }
    }

