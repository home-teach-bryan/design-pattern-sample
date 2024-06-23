namespace DesignPatternSample.BehavioralPatterns.Visitor;

public interface IElement
{
    void Accept(IVisitor visitor);
}