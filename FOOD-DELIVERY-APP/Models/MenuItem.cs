public class MenuItem
{
    private int menuItemId=1;
    private string menuItemName;
    private double menuItemPrice;

    public MenuItem(int id, string name, double price)
    {
        menuItemId = id;
        menuItemName = name;
        menuItemPrice = price;
    }
    public int MenuItemId
    {
        get { return menuItemId; }
    }
    public string MenuItemName
    {
        get { return menuItemName; }
    }
    public double MenuItemPrice
    {
        get { return menuItemPrice; }
    }       

}