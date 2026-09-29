public class Cart
{
    public Restaurant restaurant{get;set;}
    private List<MenuItem> cartItems;

    public Cart()
    {
        this.restaurant = null;
        this.cartItems = new List<MenuItem>();
    }

    public void addItem(MenuItem item)
    {
        if(restaurant==null)
        { Console.WriteLine("Please select a restaurant first"); return; }
        cartItems.Add(item);
    }
    public List<MenuItem> GetCartItems()
    {
        return cartItems;
    }
    public bool isEmpty()
    {
        return cartItems.Count == 0;
    }

    public double totalPrice()
    {
        double total=0.0;
        foreach(var item in cartItems)
        {
            total+=item.MenuItemPrice;
            
        }
        return total;
    }
}