public class NowOrderFactory : OrderFactory
{
    public override Order CreateOrder(User user, Cart cart, Restaurant restaurant, List<MenuItem> items, IPaymentStrategy paymentStrategy, double totalPrice, string deliveryType)
    {
        Order order;
        if(deliveryType=="Delivery")
        {
            DeliveryOrder deliveryOrder=new DeliveryOrder();
            deliveryOrder.UserAddress=user.address;
            order=deliveryOrder;
        }
        else
        {
            PickupOrder pickupOrder=new PickupOrder();
            pickupOrder.setRestaurantAddress(restaurant.RestaurantAddress);
            order = pickupOrder;
        }
        order.user=user;
        order.restaurant=restaurant;
        order.setItems(items);
        order.paymentStrategy=paymentStrategy;
        order.processPayment();
        return order;
        
    }
}