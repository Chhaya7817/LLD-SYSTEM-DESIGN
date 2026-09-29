Zomato zomato=new Zomato();
List<Restaurant> restaurants= zomato.SearchRestaurantByLocation("Delhi");
if(restaurants.Count==0)
{
    Console.WriteLine("Restaurant Not Found");
}
foreach(Restaurant res in restaurants)
{
    Console.WriteLine(res.RestaurantName);
}
User user=new User(1,"Ravi","Delhi");

zomato.SelectRestaurant(user,restaurants[0]);
zomato.AddToCart(user, 1);
zomato.AddToCart(user, 2);
zomato.AddToCart(user, 3);
zomato.PrintCartItems(user);
IPaymentStrategy paymentStrategy=new CreditCard();
Order order= zomato.CheckoutNow(user,"Pickup",paymentStrategy);

//zomato.ProcessPayment(user, order);


