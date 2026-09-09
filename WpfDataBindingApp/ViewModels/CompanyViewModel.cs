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
    public class CompanyViewModel : INotifyPropertyChanged
    {
        Company company;

        public CompanyViewModel(Company company)
            => this.company = company;

        public string Title
        {
            get => company.Title;
            set
            {
                if(company.Title != value)
                {
                    company.Title = value;
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
