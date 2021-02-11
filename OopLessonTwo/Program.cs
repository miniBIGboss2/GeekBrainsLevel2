using System;

namespace OopLessonTwo
{
    public static class Program
    {
        public static void Main()
        {
            var array = new Employee[5];

            array[0] = new EmployeeHourly("James", 30);
            array[1] = new EmployeeSalary("John", 1500);
            array[2] = new EmployeeHourly("Robert", 25);
            array[3] = new EmployeeSalary("Mary", 1800);
            array[4] = new EmployeeSalary("Patricia", 1750);

            foreach (var i in array)
            {
                i.PrintInfo();
            }

            Array.Sort(array, new SalaryComparer());
            
            foreach (var i in array)
            {
                i.PrintInfo();
            }

            Console.ReadKey();
        }
    }
}