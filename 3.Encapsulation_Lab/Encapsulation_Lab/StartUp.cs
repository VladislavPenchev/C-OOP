namespace Encapsulation_Lab
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {

            //var lines = int.Parse(Console.ReadLine());
            //var persons = new List<Person>();
            //for (int i = 0; i < lines; i++)
            //{
            //    var cmdArgs = Console.ReadLine().Split();
            //    var person = new Person(cmdArgs[0], cmdArgs[1], int.Parse(cmdArgs[2]));
            //    persons.Add(person);
            //}
            //persons.OrderBy(p => p.FirstName)
            //       .ThenBy(p => p.Age)
            //       .ToList()
            //       .ForEach(p => Console.WriteLine(p.ToString()));


            //Task2
            var lines = int.Parse(Console.ReadLine());
            var persons = new List<Person>();
            for (int i = 0; i < lines; i++)
            {
                try
                {
                    var cmdArgs = Console.ReadLine().Split();
                    var person = new Person(cmdArgs[0],
                    cmdArgs[1],
                    int.Parse(cmdArgs[2]),
                    double.Parse(cmdArgs[3]));
                    persons.Add(person);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            double bonus = double.Parse(Console.ReadLine());

            persons.ForEach(p => p.IncreaseSalary(bonus));
            persons.ForEach(p => Console.WriteLine(p.ToString()));

        }
    }
}
