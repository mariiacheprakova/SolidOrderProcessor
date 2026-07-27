using System;
using System.Collections.Generic;
using System.Text;
using SolidOrderProcessor.Services;
using SolidOrderProcessor.Models;
using SolidOrderProcessor.Observers;



namespace SolidOrderProcessor.Facades;

public class OrderFacade
{
    private readonly OrderService _orderService;
    private readonly OrderEventPublisher _orderEventPublisher;

    public OrderFacade(OrderService orderService,OrderEventPublisher orderEventPublisher)
    {
        _orderService = orderService;
        _orderEventPublisher = orderEventPublisher;
    }
   

    public async Task PlaceOrder(Order order)
    {
        await _orderService.ProcessOrder(order);
        _orderEventPublisher.PublishOrderPlaced(order);
    }
}
