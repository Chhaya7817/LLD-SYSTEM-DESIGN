public class PickupOrder : Order
{
    private string pickupLocation;
    public PickupOrder()
    {
        pickupLocation="";
    }
    public override string getType()
    {
        return "Pickup";
    }
    public void setRestaurantAddress(string location)
    {
        pickupLocation=location;
    }
    public string getRestaurantLocation()
    {
        return pickupLocation;
    }
}