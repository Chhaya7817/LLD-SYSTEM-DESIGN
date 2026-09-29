public class Restaurant
{
    private int restaurantId=1;
    private string restaurantName;
    private string restaurantAddress;

    private List<MenuItem> menuItems;

    public Restaurant(string name, string address)
    {
        restaurantName = name;
        restaurantAddress = address;
        menuItems = new List<MenuItem>();
        restaurantId++;
    }

    public int RestaurantId
    {
        get { return restaurantId; }
        set { restaurantId = value; }
    }
    public string RestaurantName
    {
        get { return restaurantName; }
        set { restaurantName = value; }
    }
    public string RestaurantAddress
    {
        get { return restaurantAddress; }
        set { restaurantAddress = value; }
    }
    public void AddMenuItem(MenuItem item)
    {
        menuItems.Add(item);
    }

    public List<MenuItem> GetMenuItems()
    {
        return menuItems;
    }

}