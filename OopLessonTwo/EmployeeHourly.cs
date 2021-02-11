namespace OopLessonTwo
{
    public class EmployeeHourly : Employee
    {
        public EmployeeHourly(string name, double hourlyRate) : base(name)
        {
            HourlyRate = hourlyRate;
        }
        private double HourlyRate { get; }

        protected override double CalculatePayment()
        {
            return 20.8 * 8 * HourlyRate;
        }
    }
}