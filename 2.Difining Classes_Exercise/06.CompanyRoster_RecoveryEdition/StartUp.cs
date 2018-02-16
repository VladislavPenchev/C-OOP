namespace _06.CompanyRoster_RecoveryEdition
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        public static void Main()
        {
            int numberOfEmployees = int.Parse(Console.ReadLine());

            List<Employee> listOfEmpl = new List<Employee>();

            for (int i = 0; i < numberOfEmployees; i++)
            {
                string[] informationForEmployee = Console
                                                    .ReadLine()
                                                    .Split(' ');

                Employee employee = new Employee(
                    informationForEmployee[0],
                    decimal.Parse(informationForEmployee[1]),
                    informationForEmployee[2],
                    informationForEmployee[3]
                );

                if (informationForEmployee.Length > 4)
                {
                    if (int.TryParse(informationForEmployee[4], out int age))
                    {
                        employee.Age = age;
                    }
                    else
                    {
                        employee.Email = informationForEmployee[4];
                    }
                }
                if (informationForEmployee.Length > 5)
                {
                    employee.Age = int.Parse(informationForEmployee[5]);
                }


                listOfEmpl.Add(employee);
            }

            var depart = listOfEmpl
                .GroupBy(empl => empl.Department)
                .Select(gr => new
                {
                    Name = gr.Key,
                    AverageSalary = gr.Average(em => em.Salary),
                    Employee = gr
                })
               .OrderByDescending(gr => gr.AverageSalary)
               .FirstOrDefault();

            foreach (var empl in depart.Employee )
            {
                //TODO:
                //PrintMethod in Employye
            }
        }
    }
}
