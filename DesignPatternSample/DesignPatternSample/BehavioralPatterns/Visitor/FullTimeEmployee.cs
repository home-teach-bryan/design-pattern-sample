namespace DesignPatternSample.BehavioralPatterns.Visitor;

public class FullTimeEmployee : IElement
{
    public string Name { get; private set; }
    public decimal MonthlySalary { get; private set; }

    public FullTimeEmployee(string name, decimal monthlySalary)
    {
        this.Name = name;
        this.MonthlySalary = monthlySalary;
    }
    
    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}