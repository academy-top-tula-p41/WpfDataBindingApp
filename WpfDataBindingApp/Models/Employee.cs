using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfDataBindingApp.Models
{
    public class Employee
    {
        public string Name { get; set; } = null!;
        public int Age { get; set; }
        public Company? Company { get; set; }
    }
}
