public class RestaurantManager
{
    List<Restaurant> restaurants=new List<Restaurant>();
    static RestaurantManager instance;
    public RestaurantManager()
    {
        
    }
    public static RestaurantManager getInstance()
    {
        if(instance==null)
        {
            instance=new RestaurantManager();
        }
        return instance;
    }
    public void addRestaurant(Restaurant res)
    {
        restaurants.Add(res);
    }
    public List<Restaurant> SearchRestaurantsByLocation(string loc)
    {
        List<Restaurant> ans=new List<Restaurant>();
        foreach(var res in restaurants)
        {
            if(res.RestaurantAddress.Contains(loc))
            {
                ans.Add(res);
            }
        }
        return ans;
    }
}