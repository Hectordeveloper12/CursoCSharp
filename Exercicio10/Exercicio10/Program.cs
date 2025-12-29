using System;
using System.Globalization;

namespace Exercicio10;

public class Program
{
    public static void Main()
    {
        Console.Write("How many employees will be registered? ");
        int qnt = int.Parse(Console.ReadLine());
        List<Employee> employees = [];

        for (int i = 1; i <= qnt; i++)
        {
            Console.WriteLine("Emplyoee #" + i);
            Console.Write("Id: ");
            int id = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Name: ");
            string name = Console.ReadLine()!;
            Console.WriteLine("Salary: ");
            double salary = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

            employees.Add(new Employee(id, name!, salary));
        }

        Console.WriteLine();
        Console.Write("Enter the employee id that will have salary increase: ");
        int selectId = int.Parse(Console.ReadLine()!);
        //Achar o Id, que no caso eu acho a indice para depois achar o ID
        int searchedEmployeeIndex = employees.FindIndex(x => x.Id == selectId);


        if (searchedEmployeeIndex == -1)
        {
            Console.WriteLine("This id does not exist!");
            Console.WriteLine();
            Console.WriteLine("Updated list of employees: ");

            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee.Id + ", " + employee.Name + ", R$" + employee.Salary.ToString("F2", CultureInfo.InvariantCulture));
            }
        } else
        {
            Console.Write("Enter the percentage: ");
            double percentage = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

            //Dificuldade para acrescentar o salário
            employees[searchedEmployeeIndex].IncreaseSalary(percentage);

            Console.WriteLine();
            Console.WriteLine("Updated list of employees: ");

            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee.Id + ", " + employee.Name + ", R$" + employee.Salary.ToString("F2", CultureInfo.InvariantCulture));
            }
        }



        
    }
}