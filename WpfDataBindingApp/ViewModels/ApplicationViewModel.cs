using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfDataBindingApp.Models;

namespace WpfDataBindingApp.ViewModels
{
    public class ApplicationViewModel
    {
        public CompanyViewModel CompanyViewModel { get; set; } = new(new Company());
        public EmployeeViewModel EmployeeViewModel { get; set; } = new(new Employee());
    }
}
