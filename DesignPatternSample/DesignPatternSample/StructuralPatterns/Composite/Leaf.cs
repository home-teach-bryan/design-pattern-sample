﻿namespace DesignPatternSample.StructuralPatterns.Composite;

public class Leaf : Component
{
    public Leaf(string name) : base(name)
    {
        
    }
    public override void Display(int depth)
    {
        Console.WriteLine(new string('-', depth) + _name);
    }
}