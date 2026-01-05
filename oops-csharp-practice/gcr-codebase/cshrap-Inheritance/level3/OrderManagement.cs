using System;

class Order
{
    public int orderId; // variables
    public DateTime orderDate;
    public Order(int orderId, DateTime orderDate) //constructor
    {
        this.orderId = orderId;
        this.orderDate = orderDate;
    }
    public virtual void GetOrderStatus()
    {
        Console.WriteLine("Order ID: " + orderId);
        Console.WriteLine("Order Date: " + orderDate);
    }
}
class ShippedOrder : Order
{
    public int trackingNumber;
    public ShippedOrder(int orderId, DateTime orderDate, int trackingNumber) : base(orderId, orderDate)
    {
        this.trackingNumber = trackingNumber;
    }
    public override void GetOrderStatus()
    {
        base.GetOrderStatus();
        Console.WriteLine("Tracking Number: " + trackingNumber);
    }

}
class DeliveredOrder : ShippedOrder
{
    public DateTime deliveryDate;
    public DeliveredOrder(int orderId, DateTime orderDate, int trackingNumber, DateTime deliveryDate) : base(orderId, orderDate, trackingNumber)
    {
        this.deliveryDate = deliveryDate;
    }
    public override void GetOrderStatus()
    {
        base.GetOrderStatus();
        Console.WriteLine("Delivery Date: " + deliveryDate);
    }

}
class OrderManagement
{
    static void Main()
    {
        DeliveredOrder order = new DeliveredOrder(101, DateTime.Now.AddDays(-5), 123456, DateTime.Now);
        order.GetOrderStatus();
        ShippedOrder shippedOrder = new ShippedOrder(102, DateTime.Now.AddDays(-3), 654321);
        shippedOrder.GetOrderStatus();
        DeliveredOrder deliveredOrder = new DeliveredOrder(103, DateTime.Now.AddDays(-7), 112233, DateTime.Now.AddDays(-1));
        deliveredOrder.GetOrderStatus();

    }
}