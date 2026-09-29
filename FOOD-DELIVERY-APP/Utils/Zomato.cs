using System.Security.Cryptography.X509Certificates;

public class Zomato
{
    public Zomato()
    {
        InitializeRestaurant();
    }
    public void InitializeRestaurant()
    {
        Restaurant restaurant1=new Restaurant("Mother's Kitchen","Delhi");
        Restaurant restaurant2=new Restaurant("Bikaji","Bangluru");
        Restaurant restaurant3=new Restaurant("Burger King","Delhi");

        MenuItem item1=new MenuItem(1,"PavBhaji",50);
        MenuItem item2=new MenuItem(2,"Cholle Bhature",150);
        MenuItem item3=new MenuItem(3,"Veg Burger",250);
        MenuItem item4=new MenuItem(4,"Bhujiya",50);
        MenuItem item5=new MenuItem(5,"Biscuit",20);
        MenuItem item6=new MenuItem(6,"Crispy Veg Burger",350);

        restaurant1.AddMenuItem(item1);
        restaurant1.AddMenuItem(item2);
        restaurant2.AddMenuItem(item4);
        restaurant2.AddMenuItem(item5);
        restaurant3.AddMenuItem(item3);
        restaurant3.AddMenuItem(item6);

        RestaurantManager restaurantManager=RestaurantManager.getInstance();
        restaurantManager.addRestaurant(restaurant1);
        restaurantManager.addRestaurant(restaurant2);
        restaurantManager.addRestaurant(restaurant3);

         
    }

    public List<Restaurant> SearchRestaurantByLocation(string loc)
    {
        return RestaurantManager.getInstance().SearchRestaurantsByLocation(loc);
    }
    public void SelectRestaurant(User user,Restaurant res)
    {
        Cart cart=user.cart;
        cart.restaurant=res;
    }
    public void AddToCart(User user,int itemcode)
    {
        bool found=false;
        if(user.cart.restaurant==null)
        {
            Console.WriteLine("Please Select Restaurant first");
            return;
        }
        foreach(MenuItem item in user.cart.restaurant.GetMenuItems())
        {
            if(item.MenuItemId==itemcode)
            {
                found=true;
                user.cart.addItem(item);
                break;
            }
        }
        if(!found) Console.WriteLine("Item Not found in Menu");
    }
    public Order CheckoutNow(User user,string orderType,IPaymentStrategy paymentStrategy)
    {
        return Checkout(user,orderType,paymentStrategy,new NowOrderFactory()); 
    }
    public Order Checkout(User user,string orderType,IPaymentStrategy paymentStrategy,OrderFactory orderFactory)
    {
        if(user.cart.isEmpty())
        {
            Console.WriteLine("Cart is Empty");
            return null;
        }
        Cart cart=user.cart;
        Restaurant restaurant=user.cart.restaurant;
        List<MenuItem> cartItems=user.cart.GetCartItems();
        double totalCost=cart.totalPrice();
        Order order = orderFactory.CreateOrder(user,cart,restaurant,cartItems,paymentStrategy,totalCost,orderType);
        OrderManager.getInstance().AddOrder(order);
        return order;
    }
    public bool ProcessPayment(User user,Order order)
    {
        return order.processPayment();
    }
    public void PrintCartItems(User user)
    {
        Console.WriteLine("---Cart Items---");
        foreach(MenuItem item in user.cart.GetCartItems())
        {
            Console.WriteLine($"{item.MenuItemId}. {item.MenuItemName} {item.MenuItemPrice}");
            
        }
        
    }
}