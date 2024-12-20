using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionNumber5
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }

        public EmployeeStatus EmployeeStatus { get; set; } //active,resigned,retired
    }

    public enum EmployeeStatus
    {
        Active,
        Resigned,
        Retired
    }
}
