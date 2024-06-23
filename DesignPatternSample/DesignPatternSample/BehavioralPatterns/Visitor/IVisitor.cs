namespace DesignPatternSample.BehavioralPatterns.Visitor;

public interface IVisitor
{
     void Visit(FullTimeEmployee employee);
     void Visit(PartTimeEmployee employee);
    
}