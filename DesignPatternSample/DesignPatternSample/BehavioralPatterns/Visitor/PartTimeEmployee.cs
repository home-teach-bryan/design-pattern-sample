namespace DesignPatternSample.BehavioralPatterns.Visitor;

public class PartTimeEmployee : IElement
{
    public string Name { get; private set; }
    public decimal HourlyRate { get; private set; }
    public decimal HoursWorked { get; private set; }

    public PartTimeEmployee(string name, decimal hourlyRate, decimal hoursWorked)
    {
        this.Name = name;
        this.HourlyRate = hourlyRate;
        this.HoursWorked = hoursWorked;
    }
    
    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}