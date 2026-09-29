public class DeliveryOrder : Order
{
    public string UserAddress;
    public DeliveryOrder()
    {
        UserAddress="";
    }
    public override string getType()
    {
        return "Delivery";
    }
    public void setUserAddress(string location)
    {
        UserAddress=location;
    }
    public string getUserAddress()
    {
        return UserAddress;
    }
}