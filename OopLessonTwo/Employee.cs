using System;
using System.Collections;
using System.Collections.Generic;

namespace OopLessonTwo
{
    public abstract class Employee :IEnumerable<Employee>
    {
        protected Employee(string name)
        {
            Name = name;
        }
        
        private string Name { get; }
        internal double Salary => CalculatePayment();

        protected abstract double CalculatePayment();

        public void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}. Monthly Salary: {Salary}.");
        }

        IEnumerator<Employee> IEnumerable<Employee>.GetEnumerator()
        {
            return (IEnumerator<Employee>) GetEnumerator();
        }

        public IEnumerator GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}