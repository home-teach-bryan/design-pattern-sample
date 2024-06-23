namespace DesignPatternSample.BehavioralPatterns.Visitor;

public class Payroll
{
    private List<IElement> _employees = new List<IElement>();

    public void Attach(IElement employee)
    {
        _employees.Add(employee);
    }

    public void Detach(IElement employee)
    {
        _employees.Remove(employee);
    }

    public void Accept(IVisitor visitor)
    {
        foreach (var employee in _employees)
        {
            employee.Accept(visitor);
        }
    }
}