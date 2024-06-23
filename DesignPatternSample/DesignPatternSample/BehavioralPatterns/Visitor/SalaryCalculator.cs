namespace DesignPatternSample.BehavioralPatterns.Visitor;

public class SalaryCalculator : IVisitor
{
    public void Visit(FullTimeEmployee employee)
    {
        decimal salary = employee.MonthlySalary;
        Console.WriteLine($"{employee.Name} is a full-time employee. Monthly Salary: {salary}");
    }

    public void Visit(PartTimeEmployee employee)
    {
        decimal salary = employee.HourlyRate * employee.HoursWorked;
        Console.WriteLine($"{employee.Name} is a part-time employee. Monthly Salary: {salary}");
    }
}