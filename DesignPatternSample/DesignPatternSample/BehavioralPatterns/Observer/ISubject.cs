﻿namespace DesignPatternSample.BehavioralPatterns.Observer;

public interface ISubject
{
    void Attach(IObserver observer);
    void Detach(IObserver observer);
    void Notify(string news);
}