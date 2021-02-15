using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using StaffList.Annotations;

namespace StaffList
{
    public class ApplicationViewModel : INotifyPropertyChanged
    {
        private Employee _selectedEmployee;
        private Department _selectedDepartment;

        public ObservableCollection<Employee> Employees { get; set; }
        public ObservableCollection<Department> Departments { get; set; }

        public Employee SelectedEmployee
        {
            get => _selectedEmployee;
            set
            {
                _selectedEmployee = value;
                OnPropertyChanged("SelectedEmployee");
            }
        }

        public Department SelectedDepartment
        {
            get => _selectedDepartment;
            set
            {
                _selectedDepartment = value;
                OnPropertyChanged("SelectedDepartment");
            }
        }

        public ApplicationViewModel()
        {
            Employees = new ObservableCollection<Employee>
            {
                new Employee{ Name = "Adam", Surname = "Smith", Department = "TestDepartmentOne", Salary = 12000},
                new Employee{ Name ="Jack", Surname="Nicholson", Department = "TestDepartmentTwo", Salary = 18000},
                new Employee{ Name ="Adam", Surname="Driver", Department = "TestDepartmentOne", Salary = 17500},
                new Employee{ Name ="Jack", Surname="Black", Department = "TestDepartmentOne", Salary = 18000},
                new Employee{ Name ="Dwayne", Surname="Johnson", Department = "TestDepartmentTwo", Salary = 18000}
            };

            Departments = new ObservableCollection<Department>
            {
                new Department{Name = "TestDepartmentOne", AmountOfEmployee = 3},
                new Department{Name = "TestDepartmentTwo", AmountOfEmployee = 2}
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;
        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}