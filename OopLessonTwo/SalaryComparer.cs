using System.Collections;
using System.Collections.Generic;

namespace OopLessonTwo
{
    public class SalaryComparer : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            return (new CaseInsensitiveComparer()).Compare(x.Salary, y.Salary);
        }
    }
}