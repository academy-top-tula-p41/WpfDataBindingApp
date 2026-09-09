using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WpfDataBindingApp.Models;

namespace WpfDataBindingApp.ViewModels
{
    public class EmployeeViewModel : INotifyPropertyChanged
    {
        Employee employee;

        public EmployeeViewModel(Employee employee)
            => this.employee = employee;

        public string Name
        {
            get => employee.Name;
            set
            {
                if(employee.Name != value)
                {
                    employee.Name = value;
                    OnPropertyChanged();
                }
            }
        }

        public int Age
        {
            get => employee.Age;
            set
            {
                if(employee.Age != value)
                {
                    employee.Age = value;
                    OnPropertyChanged();
                }
            }
        }

        public Company? Company
        {
            get => employee.Company;
            set
            {
                if(employee.Company != value)
                {
                    employee.Company = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
