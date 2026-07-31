using System;
using System.Collections.Generic;
using System.Text;
using SolidOrderProcessor.Models;

namespace SolidOrderProcessor.Observers;

public class OrderEventPublisher 
{
    private readonly List<IOrderObserver> _observers = [];

    public void Subscribe(IOrderObserver observer) => _observers.Add(observer);

    public void PublishOrderPlaced(Order order)
    {
        foreach(IOrderObserver observer in _observers)
        {
            observer.OnOrderPlaced(order);
        }
    }

}
