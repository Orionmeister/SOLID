using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    /* 
                Open-Closed Principle
    
    * Class or Software entities should be open for extension,
    but closed for modification.

    * Use abstract class or an interface as a base for most common abstract features
    and use the separate classes for different implementation of abstact methods and
    create the child class object and assign it to parent.
    
    */

    public class EmployeeReport
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Level { get; set; }
        public int WorkingHours { get; set; }
        public double HourlyRate { get; set; }
    }

    public class SalaryCalculator
    {
        //Bad approach
        private readonly IEnumerable<EmployeeReport> _employeeReport;

        public SalaryCalculator(List<EmployeeReport> employeeReports)
        {
            _employeeReport = employeeReports;
        }

        public double CalculateTotalSalaries()
        {
            double totalSalaries = 0D;
            foreach (EmployeeReport employeeReport in _employeeReport)
            {
                //check level and apply bonus if demads came
                //cause modification on existing class is bad approach
                totalSalaries += employeeReport.HourlyRate * employeeReport.WorkingHours;
            }

            return totalSalaries;
        }
    }

    //Better Approach

    public abstract class BaseSalaryCalculator
    {
        protected EmployeeReport EmployeeReport { get; set; }

        public BaseSalaryCalculator(EmployeeReport   employeeReport)
        {
            EmployeeReport = employeeReport;
        }
        public abstract double CalculateSalary();
    }

    public class SeniorEmployeeSalaryCalculator : BaseSalaryCalculator
    {
        public SeniorEmployeeSalaryCalculator(EmployeeReport report)
            : base(report)
        {

        }

        public override double CalculateSalary()
        {
            return new double();
        }
    }

    public class JuniorEmployeeSalaryCalculator : BaseSalaryCalculator
    {
        public JuniorEmployeeSalaryCalculator(EmployeeReport report)
            : base(report)
        {

        }

        public override double CalculateSalary()
        {
            return new double();
        }
    }

}
