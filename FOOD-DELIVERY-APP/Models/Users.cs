public class User
{
    int UserId;
    public string UserName{get;set;}
    
    public string address{get;set;}
    public Cart cart{get;set;}

    public User(int UserId, string UserName, string location)
    {
        this.UserId = UserId;
        this.UserName = UserName;
        this.address = location;
        cart = new Cart();
    }
}