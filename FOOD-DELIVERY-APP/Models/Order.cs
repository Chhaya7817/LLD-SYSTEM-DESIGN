
public class Order
{
    private int OrderId=1;
    public User user {get;set;}
    public Restaurant restaurant {get; set;}
    public double total{ get;set;}
    List<MenuItem> orderItems;
    public IPaymentStrategy paymentStrategy{get;set;}
    public Order()
    {
        user = null;
        restaurant = null;
        paymentStrategy = null;
        total=0.0;
        OrderId=OrderId++;


    }

    public Boolean processPayment()
    {
        if(paymentStrategy!=null)
        {
            paymentStrategy.pay(total);
            return true;
        }
        else
        {
            Console.WriteLine("Please select a payment strategy");
            return false;
        }
    }
    public virtual string getType()
    { 
        return "Order";
    }
    //getter setter
  
    public void setItems(List<MenuItem> its)
    {
        orderItems=its;
        foreach(MenuItem item in orderItems)
        {
            total+=item.MenuItemPrice;
        }
    }
    

}