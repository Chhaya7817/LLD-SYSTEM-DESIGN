public abstract class OrderFactory
{
    public abstract Order CreateOrder(User user,Cart cart,Restaurant res,List<MenuItem> items,IPaymentStrategy paymentStrategy,double total,string orderType);
}