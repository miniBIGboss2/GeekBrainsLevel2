using System.ComponentModel;
using System.Runtime.CompilerServices;
using StaffList.Annotations;

namespace StaffList
{
    public class Employee : INotifyPropertyChanged
    {
        private string _name;
        private string _surname;
        private string _department;
        private int _salary;

        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }
        
        public string Surname
        {
            get => _surname;
            set
            {
                _surname = value;
                OnPropertyChanged("Surname");
            }
        }
        
        public string Department
        {
            get => _department;
            set
            {
                _department = value;
                OnPropertyChanged("Department");
            }
        }
        
        public int Salary
        {
            get => _salary;
            set
            {
                _salary = value;
                OnPropertyChanged("Salary");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}