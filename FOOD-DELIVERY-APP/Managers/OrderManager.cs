public class OrderManager
{
    static OrderManager instance;
    List<Order> orders=new List<Order>();
    private OrderManager(){}
    public static OrderManager getInstance()
    {
        if(instance==null)
        {
            instance=new OrderManager();
        }
        return instance;
    }
    public void AddOrder(Order order)
    {
        orders.Add(order);
    }
    public void listOrders()
    {
        Console.WriteLine("-----List of All Orders-----");
        foreach(var o in orders)
        {
            Console.WriteLine($"Order Type: {o.getType}, Total: {o.total}");
        } 
    }
}