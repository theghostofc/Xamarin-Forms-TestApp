using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace TestApp
{
    public class Employee
    {
        public string empName
        {
            get;
            set;
        }

        public string empType
        {
            get;
            set;
        }
    }
    public class EmployeeTemplateSelector : DataTemplateSelector
    {
        public DataTemplate PermanentEmployeeTemplate { get; set; }
        public DataTemplate ContractEmployeeTemplate { get; set; }
        public EmployeeTemplateSelector()
        {
        }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            return ((Employee)item).empType.Equals("Contract") ? ContractEmployeeTemplate : PermanentEmployeeTemplate;
        }
    }

    public class EmployeeViewModel
    {
        private List<Employee> employees;

        public List<Employee> Employees { get { return employees; } set { employees = value; } }

        public EmployeeViewModel()
        {
            Employees = new List<Employee>()
            {
                new Employee() {empName = "DMI1", empType="Permanent"},
                new Employee() {empName = "DMI2", empType="Contract"}
            };
        }
    }
}
