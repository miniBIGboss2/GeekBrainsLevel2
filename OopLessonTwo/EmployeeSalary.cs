namespace OopLessonTwo
{
    public class EmployeeSalary : Employee
    {
        public EmployeeSalary(string name, double fixedMonthlySalary) : base(name)
        {
            FixedMonthlySalary = fixedMonthlySalary;
        }
        private double FixedMonthlySalary { get; }

        protected override double CalculatePayment()
        {
            return FixedMonthlySalary;
        }
    }
}