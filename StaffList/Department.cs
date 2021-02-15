using System.ComponentModel;
using System.Runtime.CompilerServices;
using StaffList.Annotations;

namespace StaffList
{
    public class Department : INotifyPropertyChanged
    {
        private string _name;
        private int _amountOfEmployee;
        
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }
        
        public int AmountOfEmployee
        {
            get => _amountOfEmployee;
            set
            {
                _amountOfEmployee = value;
                OnPropertyChanged("AmountOfEmployee");
            }
        }

        public void IncreaseAmountOfEmployee() => _amountOfEmployee++;
        
        public void DecreaseAmountOfEmployee() => _amountOfEmployee--;

        public event PropertyChangedEventHandler PropertyChanged;
        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}